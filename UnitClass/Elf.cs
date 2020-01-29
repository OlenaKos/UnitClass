using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    class Elf : Unit, IMove, IUnit
    {

        public Elf() : base ()
        {
            Name = "Legolas";
            Age = 30;
            Intellect = 14;
            Strength = 11;
            Dexterity = 23;
            Money = 100;
            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * Dexterity;
            
        }

        public Elf(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
            Dexterity = 20;
        }

        public Elf( string name, int age, int intellect, int strength, int dexterity, int money ) : base (name, age, intellect, strength, dexterity, money)
        {

            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * Dexterity;

        }

        public override string Name { get; set; }
        public void Move()
        {
            Console.WriteLine( "Elf is moving");
        }
        public void SpecialMove()
        {
            Console.WriteLine("Elf is flying(special move)");
        }

        public void Talk()
        {

        }
        public void Trade()
        {

        }
    }
}
