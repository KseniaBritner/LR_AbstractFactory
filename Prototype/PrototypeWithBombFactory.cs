using AbstractFactory;
using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeWithBombFactory : PrototypeFactory
    {
        public PrototypeWithBombFactory()
            : base(new Mazze(),new RoomWithBomb(0), new WallWithBomb(), new Door(new Room(0), new Room(1)) ) { }
    }
}
