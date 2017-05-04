using Ninja.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.State
{
    class StandbyState : IState
    {
        public INinja ninja { get; set; }

        public StandbyState(INinja ninja)
        {
            this.ninja = ninja;
        }

        // IState implementation
        // ---------------------------------------
        public void EnterState(IState state)
        {
            throw new NotImplementedException();
        }

        public void ExitState()
        {
            throw new NotImplementedException();
        }

        // INinja implementation
        // ---------------------------------------
        public void ChangeWeapon(IWeapon weapon)
        {
            ninja.CurrentWeapon = weapon;
        }

        public void DeliberateAttack()
        {
            ninja.CurrentWeapon.DeliberateAttack();
        }

        public void SwiftAttack()
        {
            ninja.CurrentWeapon.SwiftAttack();
        }

        public void Rest()
        {

        }

        public void Wake()
        {
            Console.WriteLine("Standby is active already.");
        }

        // absolutely useless in here, gotta be implemented tho
        public IWeapon CurrentWeapon
        {
            get;
            set;
        }

        // ISuperNinja implementation
        // ---------------------------------------
        public void SuperAttack()
        {
            ninja.CurrentWeapon.SuperAttack();
        }

    }
}
