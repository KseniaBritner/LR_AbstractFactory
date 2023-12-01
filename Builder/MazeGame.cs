using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MazeGame
    {
        public static void Create(MazeBuilder build)
        {
            build.RoomBuilder(1);
            build.RoomBuilder(2);
            build.DoorBuilder(1, 2);
        }
    }
}
