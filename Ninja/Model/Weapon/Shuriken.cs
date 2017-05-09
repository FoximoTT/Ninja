using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Shuriken : IWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("Shuriken -> DeliberateAttack");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Shuriken -> SwiftAttack");
        }

        public void DeadlyAttack()
        {
            Console.WriteLine("Shuriken -> DeadlyAttack");
        }
    }
}