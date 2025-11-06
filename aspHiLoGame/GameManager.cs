using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspHiLoGame
{
    public class GameManager
    {
        public string Name { get; set; }
        public int MaxRange { get; set; }
        public int MinRange { get; set; }
        public int Guess { get; set; }

        public int RandomNumber { get; set; }

        public GameManager() { }
        //static player to maintain values during game
        static public GameManager Player = new GameManager
        {
            Name = "",
            MaxRange = 0,
            MinRange = 1,
            Guess = 0,
            RandomNumber = 0

        };
        readonly Random randnumber = new Random();

        public int GenerateRandomNumber(int maxRange)
        {
            int minRange = 1;
            return randnumber.Next(minRange, maxRange + 1);
        }
    }
}