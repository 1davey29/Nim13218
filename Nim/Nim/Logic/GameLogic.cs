using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim.Logic
{
    class GameLogic
    {
        public bool hasComputerPlayer { get; set; }
        private List<List<int>> piles;

        public List<List<int>> MyProperty
        {
            get { return piles; }
            set { piles = value; }
        }


        public void TakeTurn(bool isPlayerOne)
        {

        }
    }
}
