using Ninja.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Queue
{
    // very basic action queue, just to see if this approach will work out
    public class ActionQueue : IActionQueue
    {
        protected Queue<Action> ActionsFIFO { get; set; }

        public ActionQueue()
        {
            ActionsFIFO = new Queue<Action>();
        }

        public void Add(Action action)
        {
            ActionsFIFO.Enqueue(action);
        }

        public bool ContainsActions()
        {
            return ActionsFIFO.Count > 0;
        }

        public void ExecuteActions()
        {
            while (ActionsFIFO.Count > 0)
            {
                var action = ActionsFIFO.Dequeue();
                action();
            }
        }
    }
}
