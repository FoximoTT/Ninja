using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Shuriken : IWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("Carefully aiming... Bullseye!");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Quick draw! ...And one missed");
        }

        public void SuperAttack()
        {
            Console.WriteLine("Hayaaaaa! Nak!");
        }
    }
}