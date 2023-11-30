using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze;

namespace Factory
{
    public class BombMazeGame : MazeGame
    {
        protected override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным значением.");
            }
            return new RoomWithBomb(roomNumber);
        }
        protected override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}
