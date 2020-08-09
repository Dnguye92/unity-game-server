using System;
using System.Collections.Generic;
using System.Text;

namespace unity_game_server
{
    class GameLogic
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
