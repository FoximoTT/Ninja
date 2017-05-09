﻿using System;
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

        public Ninja()
        {
            actionQueue = new ActionQueue();
            Wake();
            ChangeWeapon(new Fists());
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