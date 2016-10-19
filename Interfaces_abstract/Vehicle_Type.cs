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
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
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

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }
    }

    class SportsBike : TwoWheeler, ISafety
    {
        public bool operateABS()
        {
            throw new NotImplementedException();
        }
    }

    class RacingCar : FourWheeler, ISafety
    {
        public bool operateABS()
        {
            throw new NotImplementedException();
        }
    }

}
