using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class RoomWithLight : Room
    {
        private static Random random = new Random();
        private readonly int _isLight;
        public RoomWithLight(int roomNumber) : base(roomNumber)
        {
            _isLight = random.Next(2);
        }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("В комнате есть лампочка");
            if (_isLight==0)
            {
                Console.WriteLine("Свет включен");
            }
            else
            {
                Console.WriteLine("Свет выключен");
            }
        }
        public override Room Clone()
        {
            return new RoomWithLight(Number);
        }
    }
}
