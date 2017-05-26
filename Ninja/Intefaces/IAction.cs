using Ninja.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Intefaces
{
    // TODO - basic actions, movement etc. 
    public interface IAction
    {
        void ChangeWeapon(IWeapon weapon);


        void Rest();
        void Wake();
    }
}
