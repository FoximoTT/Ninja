using Ninja.Intefaces;
using Ninja.Model.Weapon;
using Ninja.Queue;
using Ninja.State;
using System;

namespace Ninja.Model
{
    public class MasterNinja : IMasterNinja
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

        //default superninja instantiation
        public MasterNinja(string name)
        {
            Name = name;
            actionQueue = new ActionQueue();
            this.state = new StandbyState(this);
            ChangeWeapon(new Fists());
            Console.WriteLine($"Ninja { name } intialized.");
        }

        // in case of ninja promotion, preserving base ninja properties
        public MasterNinja(IWeapon weapon, IState state, string name, IActionQueue queue)
        {
            Name = name;
            actionQueue = queue;
            this.state = state;
            ChangeWeapon(weapon);
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

        public void DeadlyAttack()
        {
            state.DeadlyAttack();
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
