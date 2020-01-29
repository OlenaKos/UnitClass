using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    class Human : Unit, IMove, IUnit
    {
        public Human() : base()
        {
            Name = "Human";
            Age = 30;
            Intellect = 11;
            Strength = 15;
            Dexterity = 15;
            Money = 100;
            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * Strength + Dexterity;

        }
        public Human(string name, int age, int intellect, int strength, int dexterity, int money) : base(name, age, intellect, strength, dexterity, money)
        {

            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * ((Strength + Dexterity)/2);

        }

        public override string Name { get; set; }
        public void Move()
        {
            Console.WriteLine("Human is moving");
        }
        public void SpecialMove()
        {
            Console.WriteLine("Human is riding horse");
        }

        public void Talk()
        {

        }
        public void Trade()
        {

        }
    }
}
