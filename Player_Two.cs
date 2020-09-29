using System;
using System.Collections.Generic;
using System.Text;

namespace PingPongHM
{
    class Player_Two
    {
        public delegate void PlayerName(string message);
        public event PlayerName Notify;
        public Player_Two()
        {
            Name = "Player_2";
        }
        public string Name { get; private set;}
        public void Hit1()
        {
            Notify?.Invoke($"Player_Two hit Player_One");
        }
    }
}
