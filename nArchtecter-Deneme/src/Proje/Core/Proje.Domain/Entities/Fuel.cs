using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Entities;

public class Fuel : Entity<Guid> //yakıt 
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }
    public Fuel()
    {
        Models = new HashSet<Model>();
    }
    public Fuel(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
