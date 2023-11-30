using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class LightMazeGame : MazeGame
    {
        protected override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), " Комната с отрицательным значением.");
            }
            return new RoomWithLight(roomNumber);
        }
    }
}
