using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MazeWithBombFactory : MazeFactory
    {
        public override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Отрицательный номер");
            }
            return new RoomWithBomb(roomNumber);
        }
        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}
