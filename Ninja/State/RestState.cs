using Ninja.Intefaces;
using System;

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

        public void ChangeWeapon(IWeapon weapon)
        {
            Console.WriteLine($"{ ninja.Name } | Cannot ChangeWeapon while resting!");
        }

        public void DeliberateAttack()
        {
            Console.WriteLine($"{ ninja.Name } | Cannot DeliberateAttack while resting!");
        }

        public void SwiftAttack()
        {
            Console.WriteLine($"{ ninja.Name } | Swiftattack while resting -> waking up to attack!");
            ninja.ActionQueue.Add(() =>
            {
                Console.Write($"{ ninja.Name } | ");
                ninja.CurrentWeapon.SwiftAttack();
            });
            Wake();
        }

        public void Rest()
        {
            Console.WriteLine($"{ ninja.Name } | Resting already.");
        }

        public void Wake()
        {
            Console.WriteLine($"{ ninja.Name } | Standby");
            ninja.State = new StandbyState(ninja);
        }

        public void DeadlyAttack()
        {
            Console.WriteLine($"{ ninja.Name } | Cannot DeadlyAttack while resting!");
        }
    }
}
