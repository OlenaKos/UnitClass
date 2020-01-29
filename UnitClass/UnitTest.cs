using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitClass
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void CreateUnit()
        {
            new Elf("Legolas", 50, 5);
        }

        [Test]
        public void GetHealthTest()
        {
            Unit unit = new Elf("Legolas", 50, 5);
            Assert.AreEqual(unit.GetHealth(), 50);
        }

        [Test]
        public void TakeDamageTest()
        {
            Unit unit = new Elf("Legolas", 100, 20);
            unit.TakeDamage(15);
            Assert.AreEqual(85, unit.GetHealth());
        }

        [Test]
        public void AttackTest()
        {
            Unit elf = new Elf();
            Unit orc = new Orc();

            elf.Attack(orc);
            Assert.AreEqual(184, orc.GetHealth());

        }
    }
}
