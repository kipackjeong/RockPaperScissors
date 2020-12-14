using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Helpers
{
    public class Hand
    {
        public OptionsRPS Selection { get; set; }
        public OptionsRPS WinAgainst { get; set; }
        public OptionsRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }
            else if (LosesAgainst == opponentHand.Selection)
            {
                return GameStatus.Lost;
            }

            return GameStatus.Win;
        }
    }
}
