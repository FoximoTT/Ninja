﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Intefaces
{
    public interface IState : IAction, ICombat, IAdvancedCombat
    {
        void EnterState(IState state);
        void ExitState();
    }
}
