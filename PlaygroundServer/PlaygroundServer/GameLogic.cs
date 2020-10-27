using System;
using System.Collections.Generic;
using System.Text;

namespace PlaygroundServer
{
    class GameLogic
    {
        public static void Update()
        {
            foreach (var client in Server.clients.Values)
            {
                if(client.player != null)
                {
                    client.player.Update();
                }
            }

            ThreadManager.UpdateMain();
        }
    }
}
