using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Fists : IWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("Fists -> DeliberateAttack");
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