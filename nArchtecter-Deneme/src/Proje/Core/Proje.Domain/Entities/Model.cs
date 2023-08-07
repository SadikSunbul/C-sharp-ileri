using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Entities;

public class Model : Entity<Guid> //model
{
    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; }
    public Guid TransmissonId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }


    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get; set; }
    public virtual Transmission? Transmission { get; set; }

    public virtual ICollection<Car> Cars { get; set; }//1 modeın bırsuru arabası olur

    public Model()
    {
        Cars = new HashSet<Car>();//bos bır lıste gibi
    }
    public Model(Guid id, Guid brandId, Guid fuelId, Guid transmissonId, string name, decimal dailPrice, string imageUrl) : this()
    {
        Id = id;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissonId = transmissonId;
        Name = name;
        DailyPrice = dailPrice;
        ImageUrl = imageUrl;
    }

}