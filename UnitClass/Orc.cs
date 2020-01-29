using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    class Orc : Unit, IMove, IUnit
    {

        public Orc() : base()
        {
            Name = "Orc";
            Age = 30;
            Intellect = 11;
            Strength = 23;
            Dexterity = 10;
            Money = 100;
            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * Strength;

        }

        public Orc(string name, int hp, int damage)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            Strength = 15;
        }

        public Orc(string name, int age, int intellect, int strength, int dexterity, int money) : base(name, age, intellect, strength, dexterity, money)
        {

            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * Strength;

        }

        public override string Name { get; set; }
        public void Move()
        {
            Console.WriteLine("Orc is moving");
        }
        public void SpecialMove()
        {
            Console.WriteLine("Orc is riding wolf");
        }

        public void Talk()
        {

        }
        public void Trade()
        {

        }
    }
}
