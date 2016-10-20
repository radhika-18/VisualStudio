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
        public void getVehicleDetails()
        {
            Console.WriteLine("Enter the color of the twowheeler");
            this.Color = Console.ReadLine();
            Console.WriteLine("Enter the capacity of the twowheeler");
            this.Capacity = Convert.ToInt32(Console.ReadLine());
        }
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
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
        public void getVehicleDetails()
        {
            Console.WriteLine("Enter the color of the fourwheeler");
            this.Color = Console.ReadLine();
            Console.WriteLine("Enter the capacity of the fourwheeler");
            this.Capacity = Convert.ToInt32(Console.ReadLine());
        }
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the four wheeler:{0}\nCapacity of the four wheeler:{1}", this.Color, this.Capacity);
        }
    }

    class SportsBike : TwoWheeler, ISafety
    {
        public bool operateABS()
        {
            throw new NotImplementedException();
        }
        public override void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the sportsbike:{0}\nCapacity of the sportsbike:{1}", this.Color, this.Capacity);
        }
    }

    class RacingCar : FourWheeler, ISafety
    {
        public bool operateABS()
        {
            throw new NotImplementedException();
        }
        public override void PrintDetails()
        {
            Console.WriteLine("\nThe details entered are as follows:\nColor of the racingcar:{0}\nCapacity of the racing:{1}", this.Color, this.Capacity);
        }
    }

}
