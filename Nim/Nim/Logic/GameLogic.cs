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

        public void TakeAiTurn(GameWindow game)
        {
            Random rand = new Random();
            int pile = 0;
            int blockCount = 0;

            NEWPILE:

            pile = rand.Next(4);

            switch (pile)
            {
                case 0:

                    if (game.Pile_1.Children.Count > 0)
                    {
                        blockCount = rand.Next(game.Pile_1.Children.Count) + 1;
                        
                        for (int i = 0; i < blockCount; i++)
                        {
                            game.Pile_1.Children.RemoveAt(0);
                        }
                    }
                    else
                    {
                        goto NEWPILE;
                    }

                    break;

                case 1:

                    if (game.Pile_2.Children.Count > 0)
                    {
                        blockCount = rand.Next(game.Pile_2.Children.Count) + 1;

                        for (int i = 0; i < blockCount; i++)
                        {
                            game.Pile_2.Children.RemoveAt(0);
                        }
                    }
                    else
                    {
                        goto NEWPILE;
                    }

                    break;

                case 2:

                    if (game.Pile_3.Children.Count > 0)
                    {
                        blockCount = rand.Next(game.Pile_3.Children.Count) + 1;

                        for (int i = 0; i < blockCount; i++)
                        {
                            game.Pile_3.Children.RemoveAt(0);
                        }
                    }
                    else
                    {
                        goto NEWPILE;
                    }

                    break;

                case 3:

                    if (game.Pile_4.Children.Count > 0)
                    {
                        blockCount = rand.Next(game.Pile_4.Children.Count) + 1;

                        for (int i = 0; i < blockCount; i++)
                        {
                            game.Pile_4.Children.RemoveAt(0);
                        }
                    }
                    else
                    {
                        goto NEWPILE;
                    }

                    break;

                default:

                    break;
            }
        }
    }
}
