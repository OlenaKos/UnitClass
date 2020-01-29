using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    abstract class Unit : IAttack
    {
        abstract public string Name { get; set; }
        public int Age { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Intellect { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }

        public int GetHealth()
        {
            return HP;
        }

        public int Money { get; set; }
        public int Damage { get; set; }

        public Unit()
        {
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }

        public Unit(string name, int age, int intellect, int strength, int dexterity, int money)
        {
            Name = name;
            Age = age;
            Intellect = intellect;
            Strength = strength;
            Dexterity = dexterity;
            Money = money;
            HP = Strength * 10;
            MP = Intellect * 10;
            Damage = 2 * strength;

        }

        public void Attack(Unit unit)
        {
            unit.HP = unit.HP - Damage;
        }
    }
}
