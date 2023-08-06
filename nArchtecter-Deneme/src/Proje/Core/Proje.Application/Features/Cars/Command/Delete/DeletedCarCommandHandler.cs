using AutoMapper;
using MediatR;
using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Proje.Application.Features.Cars.Command.Delete
{
    public class DeletedCarCommandHandler : IRequestHandler<DeletedCarCommandRequest, DeletedCarCommandRespons>
    {
        private readonly IMapper mapper;
        private readonly ICarRepository carRepository;

        public DeletedCarCommandHandler(IMapper mapper, ICarRepository carRepository)
        {
            this.mapper = mapper;
            this.carRepository = carRepository;
        }

        public async Task<DeletedCarCommandRespons> Handle(DeletedCarCommandRequest request, CancellationToken cancellationToken)
        {
            Car? car = await carRepository.GetAsync(i => i.Id == request.Id && i.Marka == request.Marka);
            if (car == null)
            {
                throw new ArgumentNullException();
            }

            await carRepository.DeleteAsync(car);

            return new DeletedCarCommandRespons() { Car = car };
        }
    }
}
