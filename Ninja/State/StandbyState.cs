using Ninja.Intefaces;
using System;

namespace Ninja.State
{
    class StandbyState : IState
    {
        public INinja ninja { get; set; }

        public StandbyState(INinja ninja)
        {
            this.ninja = ninja;
            ninja.ActionQueue.ExecuteActions();
        }

        // IState implementation
        // ---------------------------------------

        public void ChangeWeapon(IWeapon weapon)
        {
            ninja.CurrentWeapon = weapon;
        }

        public void HeavyAttack()
        {
            Console.Write($"{ ninja.Name } | ");
            ninja.CurrentWeapon.HeavyAttack();
        }

        public void SwiftAttack()
        {
            Console.Write($"{ ninja.Name } | ");
            ninja.CurrentWeapon.SwiftAttack();
        }

        public void Rest()
        {
            Console.WriteLine($"{ ninja.Name } | Resting");
            ninja.State = new RestState(ninja);
        }

        public void Wake()
        {
            Console.WriteLine($"{ ninja.Name } | Standby is active already.");
        }

        public void DeadlyAttack()
        {
            Console.Write($"{ ninja.Name } | ");
            ninja.CurrentWeapon.DeadlyAttack();
        }
    }
}
