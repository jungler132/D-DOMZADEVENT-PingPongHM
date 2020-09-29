using System;
using System.Collections.Generic;
using System.Text;

namespace PingPongHM
{
    class Player_One
    {
        public delegate void PlayerName(string message);
        public event PlayerName Notify;
        public Player_One()
        {
            Name = "Player_1";
        }
        public string Name { get; private set;}
        public void Hit1()
        {
           Notify?.Invoke($"Player_One hit Player_Two");
        }
    }
}
