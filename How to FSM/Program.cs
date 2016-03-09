using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_FSM
{
    class Program
    {
        enum PlayerStates
        {
            init,
            idle,
            walk,
            run,
        }

        // We Learning how to make finite state machines!!
        static void Main(string[] args)
        {
            FSM fsm = new FSM(PlayerStates.init);
            fsm.AddState(PlayerStates.init);
            fsm.AddState(PlayerStates.idle);
            fsm.AddState(PlayerStates.walk);
            fsm.AddState(PlayerStates.run);
            fsm.info();

            Console.ReadLine();
        }
    }
}
