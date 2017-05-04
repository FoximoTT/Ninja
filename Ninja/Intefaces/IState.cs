using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Intefaces
{
    public interface IState : INinja, ISuperNinja
    {
        void EnterState(IState state);
        void ExitState();
    }
}
