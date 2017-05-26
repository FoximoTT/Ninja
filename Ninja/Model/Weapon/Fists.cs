using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Fists : IWeapon
    {
        public void HeavyAttack()
        {
            Console.WriteLine("Fists -> HeavyAttack");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Fists -> SwiftAttack");
        }

        public void DeadlyAttack()
        {
            Console.WriteLine("Fists -> DeadlyAttack");
        }
    }
}