using Ninja.Intefaces;
using Ninja.Model.Weapon;
using Ninja.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Model
{
    public class SuperNinja : ISuperNinja
    {
        public IWeapon currentWeapon;
        public IState state;

        //default superninja instantiation
        public SuperNinja()
        {
            Wake();
            ChangeWeapon(new EmptyHands());
        }

        // in case of ninja promotion
        public SuperNinja(IWeapon weapon)
        {
            ChangeWeapon(weapon);
        }

        public void ChangeWeapon(IWeapon weapon)
        {
            state.ChangeWeapon(weapon);
        }

        public IWeapon CurrentWeapon
        {
            get { return currentWeapon; }
            set { currentWeapon = value; }
        }

        public void DeliberateAttack()
        {
            state.DeliberateAttack();
        }

        public void SwiftAttack()
        {
            state.SwiftAttack();
        }

        public void SuperAttack()
        {
            state.SuperAttack();
        }

        public void Rest()
        {
            Console.WriteLine("Resting");
            state = new RestState(this);
        }

        public void Wake()
        {
            Console.WriteLine("Standby");
            state = new StandbyState(this);
        }
    }
}
