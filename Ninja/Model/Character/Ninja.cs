using System;
using Ninja.Intefaces;
using Ninja.Model.Weapon;
using Ninja.State;
using Ninja.Queue;

namespace Ninja.Model
{
    public class Ninja : INinja
    {
        private IWeapon currentWeapon;
        private IState state;
        private string name;
        private IActionQueue actionQueue;

        public IWeapon CurrentWeapon
        {
            get { return currentWeapon; }
            set { currentWeapon = value; }
        }

        public IActionQueue ActionQueue
        {
            get { return actionQueue; }
            set { actionQueue = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IState State
        {
            get { return state; }
            set { state = value; }
        }

        public Ninja(string name)
        {
            Name = name;
            actionQueue = new ActionQueue();
            state = new StandbyState(this);
            ChangeWeapon(new Fists());
            Console.WriteLine($"Ninja { name } intialized.");
        }

        public void ChangeWeapon(IWeapon weapon)
        {
            state.ChangeWeapon(weapon);
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
            state.Rest();
        }

        public void Wake()
        {
            state.Rest();
        }
    }
}