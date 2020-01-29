using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    class Program
    {
        public static void Print() {
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Elf elf1 = new Elf();
            Elf elf2 = new Elf();
            Orc orc = new Orc();
            Human human = new Human();

            Console.WriteLine($"Elf1 hp = {elf1.HP}");
            Console.WriteLine($"Elf2 hp = {elf2.HP}");
            elf1.Attack (elf2);
            Console.WriteLine($"Elf1 hp = {elf1.HP}");
            Console.WriteLine($"Elf2 hp = {elf2.HP}");

            Game.Fight(elf1, orc);
            Game.Fight(elf2, human);
            Console.ReadLine();
        }
    }
}
