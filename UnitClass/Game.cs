using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    class Game
    {
        public static void Fight(Unit unit1, Unit unit2)
        {
            Console.WriteLine("The battle begin");
            Console.WriteLine($"Health of {unit1.Name} equal to {unit1.HP}");
            Console.WriteLine($"Health of {unit2.Name} equal to {unit2.HP}");

            while (!((unit1.HP < 0) || (unit2.HP < 0)))
            {

                unit1.Attack(unit2);
                if (unit2.HP > 0)
                {
                    unit2.Attack(unit1);
                }
                Console.WriteLine($"Health of {unit1.Name} equal to {unit1.HP}");
                Console.WriteLine($"Health of {unit2.Name} equal to {unit2.HP}");
                if (unit1.HP < 0)
                {
                    Console.WriteLine($"{unit2.Name} win the battle");
                }
                else if (unit1.HP < 0)
                {
                    Console.WriteLine($"{unit1.Name} win the battle");
                }
            }
        }
    }
}
