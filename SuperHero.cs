using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero03
{
    //string myName = "Barry Allen";
    //string codeName = "The Flash";
    //string[] Ability = new string[] { "Run at mac5", "go back in the past" }
    public class SuperHero
    {

      
        public string Alias { get; set; }
        public string HeroName { get; set; }

        public string[] Powers { get; set; }


        public SuperHero()
        {

        }

        public SuperHero(string _alias, string _heroName, string[] _powers)
        {
            Alias = _alias;
            HeroName = _heroName;
            Powers = _powers;
        }

        public override string ToString()
        {

           return  $"my name is {Alias} also known as {HeroName}";

        }

        public void DisplayPowers()
        {

            foreach (string powers in Powers)
            {
                Console.WriteLine($"I am able to {powers}");
            }

        }
    }
}
