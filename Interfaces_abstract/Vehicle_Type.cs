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

   
        public virtual void getVehicleDetails()
        {
            Console.WriteLine("\nEnter the color of the vehicle");
            this.Color = Console.ReadLine();
            Console.WriteLine("\nEnter the capacity of the vehicle");
            this.Capacity = Convert.ToInt32(Console.ReadLine());
            PrintDetails();

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

   
        public virtual object getVehicleDetails()
        {
            Console.WriteLine("\nEnter the color of the vehicle");
            this.Color = Console.ReadLine();
            Console.WriteLine("\nEnter the capacity of the vehicle");
            this.Capacity = Convert.ToInt32(Console.ReadLine());
            return this;
            
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the four wheeler:{0}\nCapacity of the four wheeler:{1}", this.Color, this.Capacity);
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
        public override void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the sports bike:{0}\nCapacity of the sports bike:{1}\nAir brakes available:{2}", this.Color, this.Capacity);
        }
        public override void getVehicleDetails()
        {
            Console.WriteLine("******************Enter the details for sports bike**************");
            base.getVehicleDetails();
        }

        public void Brake()
        {
            throw new NotImplementedException();
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
            Console.WriteLine(airBrakeAvailable);
            while (airBrakeAvailable != "YES" && airBrakeAvailable != "NO")
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

       

        public new void getVehicleDetails()
        {
            Console.WriteLine("******************Enter the details for racing car***************");
            object details = base.getVehicleDetails();
            //var properties=details.GetType().GetProperties();
            //foreach (var p in properties)
            //{
            //    (p.GetValue(details,null));
            //}

            Brake();

        }

        public void Brake()
        {
            if (airBrakes())
                Console.WriteLine("Air brakes activated");
            else
                Console.WriteLine("Air brakes not activated");
        } 
    }

}
