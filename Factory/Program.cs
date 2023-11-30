using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factoryMethod1 = new MazeGame();
            var maze1 = factoryMethod1.Create();
            var factoryMethod2 = new BombMazeGame();
            var maze2 = factoryMethod1.Create();
            var factoryMethod3 = new LightMazeGame();
            var maze3 = factoryMethod1.Create();
            Console.ReadLine();
        }
    }
}
