using System;
using System.Collections.Generic;

namespace CrashSite.Aliens
{
    public class Alien
    {
        public static List<Alien> AliensList = new List<Alien>();
        private string _alienName;
        private bool _hostility;
        private int _bodyCount;

        public Alien(string alienName, bool hostility, int bodyCount)
        {
            _alienName = alienName;
            _hostility = hostility;
            _bodyCount = bodyCount;
        }
        public string GetAlienName()
        {
            return _alienName;
        }
        public bool GetHostility()
        {
            return _hostility;
        }
        public int GetbodyCount()
        {
            return _bodyCount;
        }
        public void SetAlienName(string newAlienName)
        {
            _alienName = newAlienName;
        }
        public void SetHostility(bool newHostility)
        {
            _hostility = newHostility;
        }
        public void SetBodyCount(int newBody)
        {
            _bodyCount = newBody;
        }
        public static void Ship()
        {
            Console.WriteLine("Which zone would you like to explore?");
            Console.WriteLine("Zone1: A large lake with a dark mass near the center.");
            Console.WriteLine("Zone2: A small mountain range with something looming overhead.");
            Console.WriteLine("Zone3: A seemingly bottomless crater.");
            Console.WriteLine("Select: (zone1/zone2/zone3/ship)");
        }
        public static void Zone1()
        {
            Console.WriteLine("Welcome to Zone 1");
            Console.WriteLine("As you approach the lake you identify three members of the flight crew. They are floating in the thich, ink-like water");
            Console.WriteLine("'Help!! Please help me!' A giant tentacle silences the cries by crushing the glass helment. The unfortunate cosmonaut dissapears underwater.");
            Console.WriteLine("Only the upper portion of the Alien is exposed. Roughly 12 meters in length, a razor sharp beak and a single milky eye.");
            Console.WriteLine("Would you like to log this creature or go back to the ship?");
            Console.WriteLine("Answer: Log/ship");
            string logOrShip = Console.ReadLine();
            if (logOrShip == "log")
            {
            Alien.AlienCreator();

            }
            else if (logOrShip == "ship")
            {
            Alien.Ship();
            }
        }

        public static void AlienCreator()
        {
            Console.WriteLine("What would you like to name your new alien?");
            string userNameResponse = Console.ReadLine();
            Alien alien = new Alien("string", true, 0);
            alien.SetAlienName(userNameResponse);
            AliensList.Add(alien);

            Console.WriteLine("Is the alien hostile?");
            string userHostilityResponse = Console.ReadLine();
            if (userHostilityResponse == "yes")
            {
                alien.SetHostility(true);
            }
            else
            {
                alien.SetHostility(false);
            }

            Console.WriteLine("How many bodies are surrounding the alien?");
            string stringUserBodyResponse = Console.ReadLine();
            int userBodyResponse = int.Parse(stringUserBodyResponse);
            alien.SetBodyCount(userBodyResponse);

            Console.WriteLine("Your new alien is named " + alien.GetAlienName());
            if (alien.GetHostility() == true)
            {
                Console.WriteLine("WARNING! It is hostile! " + "It has killed " + alien.GetbodyCount() + " so far!");
            }

            else
            {
                Console.WriteLine("It doesn't appear to be hostile!, however, it has killed " + alien.GetbodyCount() + " so far!");
            }

          foreach (Alien alienID in AliensList)
          {
          Console.WriteLine(alienID.GetAlienName());
          }


        }
        // public zone end below
    }
    // crashsite end below
}
  