using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Katana : IWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("Katana -> DeliberateAttack");
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