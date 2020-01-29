using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    interface IAttack
    {

        void TakeDamage(int damage);
        void Attack(Unit unit);

    }
}
