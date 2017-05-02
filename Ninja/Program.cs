using Ninja.Intefaces;
using Ninja.Model.Weapon;

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

            ISuperNinja superNinja = new Model.SuperNinja();
            superNinja.SuperAttack();
            superNinja.ChangeWeapon(new Katana());
            superNinja.SuperAttack();
        }
    }
}