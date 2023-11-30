using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MazeGame
    {
        public Mazze Create()
        {
            Room room1 = CreateRoom(1);
            Room room2 = CreateRoom(2);
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Комнаты не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Комнаты не существует");
            }
            Door door = CreateDoor(room1, room2);
            Wall wall = CreateWall();
            room1.SetSide(Direction.North, wall);
            room1.SetSide(Direction.West, wall);
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, wall);

            room2.SetSide(Direction.North, wall);
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.South, wall);

            Mazze maze = CreateMaze();
            maze.AddRoom(room1);
            maze.AddRoom(room2);
            return maze;
        }
        protected virtual Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным значением.");
            }
            return new Room(roomNumber);
        }
        protected virtual Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Комнаты не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Комнаты не существует");
            }
            return new Door(room1, room2);
        }
        protected virtual Wall CreateWall()
        {
            return new Wall();
        }
        protected virtual Mazze CreateMaze()
        {
            return new Mazze();
        }
    }
}
