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

        //// may be a better way of implementing states than now...?
        public void EnterState(IState state)
        {
            throw new NotImplementedException();
        }

        //// may be a better way of implementing states than now...?
        public void ExitState()
        {
            throw new NotImplementedException();
        }

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
            Console.WriteLine("Swiftattack while resting -> waking up to attack!");
            ninja.ActionQueue.Add(() => ninja.SwiftAttack());
            Wake();
        }

        public void Rest()
        {
            Console.WriteLine("Resting already.");
        }

        public void Wake()
        {
            ninja.Wake();
        }

        public void DeadlyAttack()
        {
            Console.WriteLine("Cannot DeadlyAttack while resting!");
        }
    }
}
