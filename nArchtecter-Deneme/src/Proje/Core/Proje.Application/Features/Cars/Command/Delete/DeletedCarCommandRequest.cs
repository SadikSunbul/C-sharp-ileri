using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Command.Delete
{
    public class DeletedCarCommandRequest:IRequest<DeletedCarCommandRespons>
    {
        public Guid Id { get; set; }
        public string Marka { get; set; }

    }
}
