﻿using System;
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
                    TwoWheeler twowheelerObj = new TwoWheeler();
                    object detailsSportsBike=twowheelerObj.getVehicleDetails();
                    //PrintDetails();
                    break;
                case 2:
                    FourWheeler fourwheelerObj = new FourWheeler();
                    fourwheelerObj.getVehicleDetails();
                    
                    break;
                case 3:
                    SportsBike sportsbikeObj = new SportsBike();
                    object detailsSportsBike = sportsbikeObj.getVehicleDetails();
                    sportsbikeObj.Brake();
                    PrintDetails(detailsSportsBike);
                    //PrintDetails();
                    break;
                case 4:
                    RacingCar racingcar = new RacingCar();
                    object detailSportCar = racingcar.getVehicleDetails();
                    racingcar.Brake();
                    PrintDetails(detailSportCar);
                    break;
                default:
                    Console.WriteLine("Enter proper choice");
                    break;                              
            }

        }

        public void PrintDetails(object details)
        {
            var properties = details.GetType().GetProperties();
            foreach (var p in properties)
            {
                Console.WriteLine(p.Name + " of the vehicle is : " + p.GetValue(details));
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
