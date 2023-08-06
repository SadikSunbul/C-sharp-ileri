using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Command.Create;

public class CreateCarCommandRequest:IRequest<CreateCarCommandRespons>
{
    public string Marka { get; set; }
    public string Model { get; set; }
}
