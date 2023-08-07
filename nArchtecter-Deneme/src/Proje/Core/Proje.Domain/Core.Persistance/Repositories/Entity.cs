using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Repositories;

public class Entity<IEntityId>: IEntityTimeStamps
{
    //Burada temel entitilerimizde olucak ortak yerlerı yazdık zaman kısmını ılerıde farklı degerlendıre bilmekk için interface yapısına koyduk 
    public IEntityId Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeletedDate { get; set; }

    public Entity()
    {
        Id = default;
    }
    public Entity(IEntityId id)
    {
        Id = id;

    }
}
