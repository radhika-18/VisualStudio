using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// Interface that contains basic attributes and details of vehicle
    /// </summary>
    interface IVehicle
    {
        string Color { get; set; }

        int Capacity { get; set; }

        void Accelerate(); //not decided the return type

        void Brake(); //return type
    }

    /// <summary>
    /// Interface to activate ABS
    /// </summary>
    interface ISafety
    {
        bool operateABS();
    }
}
