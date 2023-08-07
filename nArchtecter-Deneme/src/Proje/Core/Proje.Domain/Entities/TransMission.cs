using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Entities;

public class Transmission : Entity<Guid> //vıtest tipi
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }

    public Transmission()
    {
        Models = new HashSet<Model>();
    }
    public Transmission(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
