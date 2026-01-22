using GameConsoleBase.BaseClass;
using GameConsoleBase.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class highScore:Screen
    {
        
        public highScore() : base("highScore")
        {
                    
        }
        public override void Show()
        {
            base.Show();
            if (FluffyBirdGame.HighestScoreF > PacManGame.highestScorep && FluffyBirdGame.HighestScoreF > TetrisGame.highestScoret)
            {
                Console.WriteLine("Fluffy bird highest score: " + FluffyBirdGame.HighestScoreF);
                if (PacManGame.highestScorep > TetrisGame.highestScoret)
                {
                    Console.WriteLine("Pac man highest score: " + PacManGame.highestScorep);
                    Console.WriteLine("Tetris highest score: " + TetrisGame.highestScoret);
                }
                else
                {
                    Console.WriteLine("Tetris highest score: " + TetrisGame.highestScoret);
                    Console.WriteLine("Pac man highest score: " + PacManGame.highestScorep);
                }
              
            }
            else if (PacManGame.highestScorep > FluffyBirdGame.HighestScoreF && PacManGame.highestScorep > TetrisGame.highestScoret)
            {
                Console.WriteLine("Pac man highest score: " + PacManGame.highestScorep);
                if (FluffyBirdGame.HighestScoreF > TetrisGame.highestScoret)
                {
                    Console.WriteLine("Fluffy bird highest score: " + FluffyBirdGame.HighestScoreF);
                    Console.WriteLine("Tetris highest score: " + TetrisGame.highestScoret);
                }
                else
                {
                    Console.WriteLine("Tetris highest score: " + TetrisGame.highestScoret);
                    Console.WriteLine("Fluffy bird highest score: " + FluffyBirdGame.HighestScoreF);
                }
            }
            else if (TetrisGame.highestScoret > FluffyBirdGame.HighestScoreF && TetrisGame.highestScoret > PacManGame.highestScorep)
            {
                Console.WriteLine("Tetris highest score: " + TetrisGame.highestScoret);
                if (FluffyBirdGame.HighestScoreF > PacManGame.highestScorep)
                {
                    Console.WriteLine("Fluffy bird highest score: " + FluffyBirdGame.HighestScoreF);
                    Console.WriteLine("Pac man highest score: " + PacManGame.highestScorep);
                }
                else
                {
                    Console.WriteLine("Pac man highest score: " + PacManGame.highestScorep);
                    Console.WriteLine("Fluffy bird highest score: " + FluffyBirdGame.HighestScoreF);
                }
            }
            Console.ReadKey();
        }
    }
}
