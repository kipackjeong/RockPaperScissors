using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace RockPaperScissors.Helpers
{
    public class GameMaterials
    {
        public List<Hand> Hands = new List<Hand>()
            {
                new Hand
                {
                    Selection = OptionsRPS.Rock,
                    LosesAgainst = OptionsRPS.Paper,
                    WinAgainst = OptionsRPS.Scissors,
                    Image = "rock.jpg"
                },
                new Hand
                {
                    Selection = OptionsRPS.Paper,
                    LosesAgainst = OptionsRPS.Scissors,
                    WinAgainst = OptionsRPS.Rock,
                    Image = "paper.jpg"
                },
                new Hand
                {
                    Selection = OptionsRPS.Scissors,
                    LosesAgainst = OptionsRPS.Rock,
                    WinAgainst = OptionsRPS.Paper,
                    Image = "scissor.jpg"
                }
            };
        public Timer Timer { get; set; } = new Timer();
        public Hand OpponentHand { get; set; } = new Hand
        {
            Selection = OptionsRPS.Rock,
            LosesAgainst = OptionsRPS.Paper,
            WinAgainst = OptionsRPS.Scissors,
            Image = "rock.jpg"
        };
        public bool Lost { get; set; } = false;
    }
}
