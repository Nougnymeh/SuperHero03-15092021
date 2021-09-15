using System;

namespace SuperHero03
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Powers = new string[] { "Run at mac5", "go back in the past" };

            SuperHero superHero = new SuperHero("Barry Allen", "The Flash", Powers);

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



        }
    }
}
