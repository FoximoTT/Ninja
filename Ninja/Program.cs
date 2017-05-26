using Ninja.Intefaces;
using Ninja.Model.Weapon;
using System;

namespace Ninja
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            INinja ninja = new Model.Ninja("Akeno");

            ninja.ChangeWeapon(new Katana());
            ninja.HeavyAttack();
            ninja.SwiftAttack();

            ninja.ChangeWeapon(new Shuriken());
            ninja.HeavyAttack();
            ninja.SwiftAttack();

            Console.WriteLine();
            IMasterNinja masterNinja = new Model.MasterNinja("Mikasa");
            masterNinja.DeadlyAttack();
            masterNinja.ChangeWeapon(new Katana());
            masterNinja.DeadlyAttack();

            masterNinja.Rest();
            masterNinja.DeadlyAttack();
            masterNinja.SwiftAttack();
            masterNinja.Wake();
            masterNinja.DeadlyAttack();
        }
    }
}