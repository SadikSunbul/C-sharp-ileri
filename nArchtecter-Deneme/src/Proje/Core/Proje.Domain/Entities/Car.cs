using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Entities;

public class Car : Entity<Guid>
{
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }
    public short MinFindexScore { get; set; } //Arafabın fıyatı yuksek ıse burasıda yukselır mali durumunu bildirir
    public Enum.CarState CarState { get; set; } //araba durumu enum olarak 

    public virtual Model? Model { get; set; }
    public Car()
    {

    }
    public Car(
       Guid id,
       Guid modelId,
       Enum.CarState carState,
       int kilometer,
       short modelYear,
       string plate,
       short minFindexScore
   )
       : this()
    {
        Id = id;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        MinFindexScore = minFindexScore;
    }
}
