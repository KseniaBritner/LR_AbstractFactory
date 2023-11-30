using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MazeFactory
    {
        public virtual Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Отрицательный номер");
            }
            return new Room(roomNumber);
        }
        public virtual Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException($"Комнаты не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException($"Комнаты не существует");
            }
            return new Door(room1, room2);
        }
        public virtual Wall CreateWall()
        {
            return new Wall();
        }
        public virtual Mazze CreateMaze()
        {
            return new Mazze();
        }
    }
}
