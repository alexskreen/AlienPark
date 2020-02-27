using System;
using System.Collections.Generic;


using CrashSite.Aliens;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("You've crash landed on a strange planet. Travel to any of the 3 zones and log the Alien life you see for further research. Loacate your fallen comrads and report back to the ship. Good luck.");
            
        
            Alien.Ship();
            string userResponse = Console.ReadLine();
            if (userResponse == "zone1")
            {
                 Alien.Zone1();

            }
        }
    }
   
    
