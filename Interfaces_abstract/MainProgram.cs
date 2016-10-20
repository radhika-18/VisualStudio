using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_abstract
{
    class MainProgram
    {
        public void getVehicalType()
        {
            int choice;
            Console.WriteLine("Enter the type of vehicle to be created.\n1.Two Wheeler");
            Console.WriteLine("2.Four Wheeler");
            Console.WriteLine("3.Sports Bike");
            Console.WriteLine("4.Racing Car");
            choice= Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TwoWheeler twowheeler = new TwoWheeler();
                    twowheeler.getVehicleDetails();
                    twowheeler.PrintDetails();
                    twowheeler.Accelerate();

                    break;
                case 2:
                    FourWheeler fourwheeler = new FourWheeler();
                    fourwheeler.getVehicleDetails();
                    fourwheeler.PrintDetails();
                    fourwheeler.Accelerate();
                    break;
                case 3:
                    SportsBike sportsbike = new SportsBike();
                    sportsbike.getVehicleDetails();
                    sportsbike.PrintDetails();
                    sportsbike.Accelerate();
                    break;
                case 4:
                    RacingCar racingcar = new RacingCar();
                    racingcar.getVehicleDetails();
                    racingcar.PrintDetails();
                    racingcar.Accelerate();
                    break;
                default:
                    Console.WriteLine("Enter proper choice");
                    break;                              
            }

        }

        
        static void Main(string[] args)
        {
            MainProgram objMainProgram = new MainProgram();
            int choice;
            while (true)
            {
                Console.Write("\n*************Vehicle Application************\n");
                Console.WriteLine("1.Create Vehicle");
                Console.WriteLine("2.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 1)
                    break;
                objMainProgram.getVehicalType();
            }
        }
    }
}
