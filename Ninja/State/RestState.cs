using Ninja.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.State
{
    class RestState : IState
    {
        public INinja ninja { get; set; }

        public RestState(INinja ninja)
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
            Console.WriteLine("Cannot ChangeWeapon while resting!");
        }

        public void DeliberateAttack()
        {
            Console.WriteLine("Cannot DeliberateAttack while resting!");
        }

        public void SwiftAttack()
        {
            ninja.CurrentWeapon.SwiftAttack();
        }

        public void Rest()
        {
            Console.WriteLine("Resting already.");
        }

        public void Wake()
        {

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
            Console.WriteLine("Cannot SuperAttack while resting!");
        }
    }
}
