using System;
using Ninja.Intefaces;
using Ninja.Model.Weapon;
using Ninja.State;

namespace Ninja.Model
{
    public class Ninja : INinja
    {
        private IWeapon currentWeapon;
        private IState state;

        public Ninja()
        {
            Wake();
            ChangeWeapon(new EmptyHands());
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