using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Maze;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory1 = MazeGame.Create(SingletonFactory.Instance);
            var factory2 = MazeGame.Create(SingletonWithBombFactory.Instance);
            var factory3 = MazeGame.Create(SingletonWithLightFactory.Instance);
        }
    }
}
