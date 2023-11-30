using Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeWithLightFactory : PrototypeFactory
    {
        public PrototypeWithLightFactory()
            : base(new Mazze(), new RoomWithLight(0), new Wall(), new Door(new Room(0), new Room(1)) ){ }
    }
}
