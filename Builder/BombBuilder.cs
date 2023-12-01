using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BombBuilder : MazeBuilder
    {
        protected override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным значением.");
            }
            return new RoomWithBomb(roomNumber);
        }
        public override Mazze GetMazze()
        {
            return maze;
        }

    }
}
