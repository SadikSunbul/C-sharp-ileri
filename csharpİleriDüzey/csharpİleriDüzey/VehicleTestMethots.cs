using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpİleriDüzey
{
    public interface IVehicle
    {
        void Go();
        void Stop();
    }
    public interface IRideable
    {
        void Ride();
    }
    public interface IFlyable
    {
        void Soar();
        //ıcerısınde kod barındırmazlar ama statıc sekılde yazıla bılır artık 
        //kural barınıdırırlar ıcerılerınde
    }

    public abstract class BaseVehicle: IVehicle
    {
        public void Go()
        {
            Console.WriteLine("arac ılerılıyor");
        }

        public void Stop()
        {
            Console.WriteLine("Arac duruyor");
        }
    }

    public class Car : BaseVehicle
    {
       
    }

    public class Bike : BaseVehicle, IRideable  
    {
      
        public void Ride()
        {
            throw new NotImplementedException();
        }

       
    }
}
