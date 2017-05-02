using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Katana : IWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("He knew it was coming but he couldn't do anything about it.");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("There's no sign of suprise in his face as his head rolls on the floor.");
        }

        public void SuperAttack()
        {
            Console.WriteLine("It was this moment, when his opponent realized he is about to get fucked up.");
        }
    }
}