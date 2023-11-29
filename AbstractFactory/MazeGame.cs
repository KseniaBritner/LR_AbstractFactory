using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MazeGame
    {
        public static Mazze Create(MazeFactory factory)
        {
            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);
            Door door = factory.CreateDoor(room1, room2);
            Wall wall = factory.CreateWall();

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, wall);
            room1.SetSide(Direction.East, wall);
            room1.SetSide(Direction.West, wall);

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.West, wall);
            room2.SetSide(Direction.North, wall);

            Mazze maze = factory.CreateMaze();
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}
