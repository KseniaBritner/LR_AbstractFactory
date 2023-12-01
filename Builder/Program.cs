using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze;

namespace Builder
{
    internal class Program
    {
        static void Main()
        {
            MazeBuilder builder = new MazeBuilder();
            BombBuilder bombBuilder = new BombBuilder();
            LightBuilder lightBuilder = new LightBuilder();
            MazeGame.Create(builder);
            MazeGame.Create(bombBuilder);
            MazeGame.Create(lightBuilder);
            Mazze maze1 = builder.GetMazze();
            Mazze maze2 = bombBuilder.GetMazze();
            Mazze maze3 = lightBuilder.GetMazze();
            Console.ReadLine();
        }
    }
}
