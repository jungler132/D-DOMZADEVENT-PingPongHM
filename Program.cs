using System;

namespace PingPongHM
{
    class Program
    {
        static void Main(string[] args)
        {
            Player_One playerone = new Player_One();
            Player_Two playertwo = new Player_Two();
            playerone.Notify += Vivod_message;
            playertwo.Notify += Vivod_message;
            for (int i = 0; i < 10; i++)
            {  
                playerone.Hit1();
                playertwo.Hit1();
            }
            Console.WriteLine("Player_One dead. Player_Two dead.");
        }
        public static void Vivod_message(string message)
        {
            Console.WriteLine(message);
        }
    }

}
