using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim.Logic
{
    public enum Opponent
    {
        AI,
        Human
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }


    public class GameLogic
    {
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public bool hasComputerPlayer { get; set; }
        public List<List<int>> piles { get; set; }
        public Opponent opponentType { get; set; }
        public Difficulty difficulty { get; set; }

        public void TakeTurn(bool isPlayerOne)
        {
            if (!isPlayerOne && hasComputerPlayer)
            {

            } else
            {

            }
        }
    }
}
