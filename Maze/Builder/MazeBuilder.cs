using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maze;
using System.Threading.Tasks;

namespace Builder
{
    public class MazeBuilder
    {
        protected Mazze maze;
        public MazeBuilder()
        {
            maze = new Mazze();
        }
        public virtual void BuildRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            Room room = CreateRoom(roomNumber);
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.East, new Wall());
            maze.AddRoom(room);
        }
        public virtual void DoorBuilder(int roomNumber1, int roomNumber2)
        {
            if (roomNumber1 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            if (roomNumber2 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            Room room1 = maze.RoomNo(roomNumber1);
            Room room2 = maze.RoomNo(roomNumber2);
            if (room1 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            if (room2 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            Door door = new Door(room1, room2);
            room1.SetSide(Direction.East, door);
            room2.SetSide(Direction.West, door);
        }
        protected virtual Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            return new Room(roomNumber);
        }
    }
}

