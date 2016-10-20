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

        public void Accelerate()
        {
            Console.WriteLine("Two wheeler has started\nEnter - 1 to brake\n");
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
        public virtual void getVehicleDetails()
        {
            Console.WriteLine("\nEnter the color of the vehicle");
            this.Color = Console.ReadLine();
            Console.WriteLine("\nEnter the capacity of the vehicle");
            this.Capacity = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void PrintDetails()
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

        public void  Accelerate()
        {
            Console.WriteLine("Four wheeler has started.\nEnter -1 to brake\n");
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the four wheeler:{0}\nCapacity of the four wheeler:{1}", this.Color, this.Capacity);
        }
        public virtual void getVehicleDetails()
        {
            Console.WriteLine("\nEnter the color of the vehicle");
            this.Color = Console.ReadLine();
            Console.WriteLine("\nEnter the capacity of the vehicle");
            this.Capacity = Convert.ToInt32(Console.ReadLine());

        }
    }

    class SportsBike : TwoWheeler, ISafety
    {
        public bool airBrakes()
        {
            throw new NotImplementedException();
        }
        public override void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the sports bike:{0}\nCapacity of the sports bike:{1}", this.Color, this.Capacity);
        }
        public override void getVehicleDetails()
        {
            Console.WriteLine("Enter the details for Sports bike");
            base.getVehicleDetails();
        }
        public new void Accelerate()
        {
            Console.WriteLine("Sports bike started.\nEnter -1 to brake\n");
        }
    }

    class RacingCar : FourWheeler, ISafety
    {
        public bool airBrakes()
        {
            Console.WriteLine("Air Brakes Available: YES/NO");
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
        public  override void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the racing car:{0}\nCapacity of the racing car:{1}", this.Color, this.Capacity);
        }
        public new void Accelerate()
        {
            Console.WriteLine("Racing car started.\nEnter -1 to brake\n");
        }
        public new void getVehicleDetails()
        {
            Console.WriteLine("Enter the details for racing car");
            base.getVehicleDetails();
        }
    }

}
