using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Wall : IMapSite
    {

        public virtual void Enter()
        {
            Console.WriteLine("Стена!");
        }

        public virtual Wall Clone()
        {
            return new Wall();
        }
    }
}
