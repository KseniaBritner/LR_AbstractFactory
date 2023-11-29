using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory1 = MazeGame.Create(new MazeFactory());
            var factory2 = MazeGame.Create(new MazeWithBombFactory());
            var factory3 = MazeGame.Create(new MazeWithLightFactory());
        }
    }
}
