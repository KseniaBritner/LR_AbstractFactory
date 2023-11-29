using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class RoomWithBomb : Room
    {
        private static Random random = new Random();
        private readonly int _isDestroyed;
        public RoomWithBomb(int roomNumber) : base(roomNumber)
        {
            _isDestroyed = random.Next(2);
        }
        public override void Enter()
        {
            base.Enter();
            if (_isDestroyed==0)
            {
                Console.WriteLine("Бомба взорвалась");
            }
            else
            {
                Console.WriteLine("Бомба не взорвалась");
            }
        }
        public override Room Clone()
        {
            return new RoomWithBomb(Number);
        }
    }
}
