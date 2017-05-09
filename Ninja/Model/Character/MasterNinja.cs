using Ninja.Intefaces;
using Ninja.Model.Weapon;
using Ninja.Queue;
using Ninja.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Model
{
    public class MasterNinja : IMasterNinja
    {
        private IWeapon currentWeapon;
        private IState state;
        public IActionQueue actionQueue;

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

        //default superninja instantiation
        public MasterNinja()
        {
            actionQueue = new ActionQueue();
            Wake();
            ChangeWeapon(new Fists());
        }

        // in case of ninja promotion, preserving base ninja properties
        public MasterNinja(IWeapon weapon)
        {
            actionQueue = new ActionQueue();
            Wake();
            ChangeWeapon(weapon);
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
            Console.WriteLine("Resting");
            state = new RestState(this);
        }

        public void Wake()
        {
            Console.WriteLine("Standby");
            state = new StandbyState(this);
            ProcessActionQueue();
        }

        private void ProcessActionQueue()
        {
            while (ActionQueue.ContainsActions())
            {
                ActionQueue.Execute();
            }
        }
    }
}
