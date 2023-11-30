using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main()
        {
            MazeGame.Create(new Builder.MazeBuilder());
            MazeGame.Create(new BombBuilder());
            MazeGame.Create(new LightBuilder());
            Console.ReadLine();
        }
    }
}
