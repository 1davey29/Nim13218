using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim.Logic
{
    enum Opponent
    {
        AI,
        Human
    }

    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public class GameLogic
    {
        public bool hasComputerPlayer { get; set; }
        public List<List<int>> piles { get; set; }
        public Opponent opponentType { get; set; }
        public Difficulty difficulty { get; set; }

        public void TakeTurn(bool isPlayerOne)
        {

        }
    }
}
