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

    }

    /// <summary>
    /// Interface to activate ABS
    /// </summary>
    interface ISafety
    {
        void Brake(); 
        bool airBrakes();
    }
}
