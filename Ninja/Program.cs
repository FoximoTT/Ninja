using Ninja.Intefaces;
using Ninja.Model.Weapon;
using System;

namespace Ninja
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            INinja ninja = new Model.Ninja();

            ninja.ChangeWeapon(new Katana());
            ninja.DeliberateAttack();
            ninja.SwiftAttack();

            ninja.ChangeWeapon(new Shuriken());
            ninja.DeliberateAttack();
            ninja.SwiftAttack();

            IMasterNinja superNinja = new Model.MasterNinja();
            superNinja.DeadlyAttack();
            superNinja.ChangeWeapon(new Katana());
            superNinja.DeadlyAttack();

            Console.WriteLine($"\n DeadlyAttack test");
            superNinja.Rest();
            superNinja.DeadlyAttack();
            superNinja.SwiftAttack();
            superNinja.Wake();
            superNinja.DeadlyAttack();
        }
    }
}