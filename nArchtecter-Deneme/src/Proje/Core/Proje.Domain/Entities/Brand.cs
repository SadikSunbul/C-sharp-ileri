using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Entities;

public class Brand : Entity<Guid> //marka demek
{
    public string Name { get; set; }//herseyın bır ısmı olmak zorunda degıldır ondan common degıl 

    public virtual ICollection<Model> Models { get; set; }
    public Brand()
    {
        Models = new HashSet<Model>();
    }
    public Brand(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}