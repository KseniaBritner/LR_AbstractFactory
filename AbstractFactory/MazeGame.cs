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

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, factory.CreateWall());
            room1.SetSide(Direction.East, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.West, factory.CreateWall());
            room2.SetSide(Direction.North, factory.CreateWall());

            Mazze maze = factory.CreateMaze();
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}
