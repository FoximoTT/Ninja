using Ninja.Queue;
using System;

namespace Ninja.Intefaces
{
    public interface INinja : IAction, ICombat
    {
        string Name { get; set; }
        IWeapon CurrentWeapon { get; set; }
        IActionQueue ActionQueue { get; set; }
        IState State { get; set; }
    }
}