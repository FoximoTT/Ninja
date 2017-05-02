using Ninja.Intefaces;
using Ninja.Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Model
{
    public class SuperNinja : ISuperNinja
    {
        private IWeapon currentWeapon;

        //default superninja instantiation
        public SuperNinja()
        {
            ChangeWeapon(new EmptyHands());
        }

        // in case of ninja promotion
        public SuperNinja(IWeapon weapon)
        {
            ChangeWeapon(weapon);
        }


        public void ChangeWeapon(IWeapon weapon)
        {
            currentWeapon = weapon;
        }

        public void DeliberateAttack()
        {
            currentWeapon.DeliberateAttack();
        }

        public void SwiftAttack()
        {
            currentWeapon.SwiftAttack();
        }

        public void SuperAttack()
        {
            currentWeapon.SuperAttack();
        }
    }
}
