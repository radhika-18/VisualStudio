using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Interfaces_abstract
{
    class TwoWheeler : IVehicle
    {
        public int Capacity
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public void Average()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
    
        public void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the two wheeler:{0}\nCapacity of the two wheeler:{1}",this.Color,this.Capacity);
        }
    }

    class FourWheeler : IVehicle
    {
        public int Capacity
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public void Average()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
        public void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the two wheeler:{0}\nCapacity of the two wheeler:{1}", this.Color, this.Capacity);
        }
    }

    class SportsBike : TwoWheeler, ISafety
    {
        public bool airBrakes()
        {
            Console.WriteLine("Air Brakes Available in Bike: YES/NO");
            bool returnResult = true;
            String airBrakeAvailable = Console.ReadLine();
            airBrakeAvailable = airBrakeAvailable.ToUpper();
            while (airBrakeAvailable != "YES" || airBrakeAvailable != "NO")
            {
                Console.WriteLine("Please enter the correct Value");
                airBrakes();
            }
            if (airBrakeAvailable == "YES")
            {
                returnResult = true;
            }
            else if (airBrakeAvailable == "NO")
            {
                returnResult = false;
            }
            return returnResult;
        }
    }

    class RacingCar : FourWheeler, ISafety
    {
        public bool airBrakes()
        {
            Console.WriteLine("Air Brakes Available in Car: YES/NO");
            bool returnResult = true;
            String airBrakeAvailable = Console.ReadLine();
            airBrakeAvailable = airBrakeAvailable.ToUpper();
            while (airBrakeAvailable != "YES" || airBrakeAvailable != "NO")
            {
                Console.WriteLine("Please enter the correct Value");
                airBrakes();
            }
            if (airBrakeAvailable == "YES")
            {
                returnResult = true;
            }
            else if (airBrakeAvailable == "NO")
            {
                returnResult = false;
            }
            return returnResult;


        }
    }

}
