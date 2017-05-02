using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class EmptyHands : IWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("It is called null object.");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Google Null Object pattern.");
        }

        public void SuperAttack()
        {
            Console.WriteLine("Fist superattack");
        }
    }
}