using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Entities
{
    public class Car:Entity<Guid> //id si guid olsun dedik
    {
        public string Marka { get; set; }
        public string Model { get; set; }

    }
}
