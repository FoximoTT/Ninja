using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Katana : IWeapon
    {
        public void HeavyAttack()
        {
            Console.WriteLine("Katana -> HeavyAttack");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Katana -> SwiftAttack");
        }

        public void DeadlyAttack()
        {
            Console.WriteLine("Katana -> DeadlyAttack");
        }
    }
}