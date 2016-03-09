using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_FSM
{
    class FSM
    {
        class Transition
        {
            public Transition(Enum from, Enum to)
            {

            }
        }

        public bool AddTransition(Enum a, Enum b)
        {
            Transition t = new Transition(a, b);

            return true;
        }

        public FSM(Enum initial)
        {
            _currentState = initial;
        }

        private List<Enum> _states = new List<Enum>();
        Enum _currentState;

        public bool AddState(Enum state)
        {
            if(_states.Contains(state))
            {
                Console.WriteLine("Nope");
                return false;
            }
            if (state.GetType().IsEnum)
            {
                _states.Add(state);
                return true;
            }
            Console.WriteLine("Can't do it");
            return false;
        }

        public void info()
        {
            Console.WriteLine("FSM is comprised of...");
            int count = 0;
            foreach (Enum a in _states)
            {
                Console.WriteLine("State " + count.ToString() + ": " + a.ToString());
                count++;
            }
            Console.WriteLine("State: " + _currentState);
        }
        Dictionary<Enum, List<Transition>> TransitionTable;
    }
}
