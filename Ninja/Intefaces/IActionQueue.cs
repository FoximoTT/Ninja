using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Intefaces
{
    public interface IActionQueue
    {
        void Add(Action action);
        void ExecuteActions();
        bool ContainsActions();
    }
}