using Maze;
using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeFactory : MazeFactory
    {
        private Mazze _prototypeMaze;
        private Room _prototypeRoom;
        private Door _prototypeDoor;
        private Wall _prototypeWall;
        protected PrototypeFactory(Mazze maze, Room room, Wall wall, Door door)
        {
            if (maze == null || room == null || wall == null || door == null)
            {
                throw new ArgumentNullException("Объект не существует");
            }
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
            _prototypeDoor = door;
        }
        public PrototypeFactory() : this(new Mazze(), new Room(0),new Wall(), new Door(new Room(0),new Room(1)))
        {
        }
        public override Mazze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }
        public Room CreateRoom()
        {
            return _prototypeRoom.Clone();
        }

        public override Wall CreateWall()
        {
            return _prototypeWall.Clone();
        }
        public Door CreateDoor()
        {
            return _prototypeDoor.Clone();
        }
    }
}
