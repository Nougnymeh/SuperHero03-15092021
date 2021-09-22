using System;
using System.Collections.Generic;

namespace SuperHero03
{
    //https://github.com/DorsetOppSemster2021/SuperHero03-15092021

    class Program
    {
        static void Main(string[] args)
        {

            //  string[] Powers = new string[] { "Run at mac5", "go back in the past" };

            List<string> Powers = new List<string>() { "Run at mac5", "go back in the past" };

            SuperHero superHero = new SuperHero("Barry Allen", "The Flash", Powers.ToArray());

            string description = superHero.ToString();

            Console.WriteLine(description);


            superHero.DisplayPowers();

            //===================================
            SuperHero superHero2 = new SuperHero();
            superHero2.Alias = "Clarke Kent";
            superHero2.HeroName = "SuperMan";
            superHero2.Powers = new string[] { "X-Ray Vision", "Flight" };

            Console.WriteLine(superHero2.ToString());


            superHero2.DisplayPowers();

            SuperHero superHero3 = new()
            {
                Alias = "Bruce Banner",
                HeroName = "The Hulk",
                Powers = new string[] { "Super Strength" },


            };

            superHero3.DisplayPowers();




        }
    }
}
