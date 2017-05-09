using Ninja.Queue;
using System;

namespace Ninja.Intefaces
{
    public interface INinja : IAction, ICombat
    {
        IWeapon CurrentWeapon { get; set; }
        IActionQueue ActionQueue { get; set; }

        void Rest();
        void Wake();
    }
}