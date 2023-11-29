using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class WallWithBomb : Wall
    {
        private bool _isDestroyed;

        public void SetIsDestroyed(bool isDestroyed)
        {
            _isDestroyed = isDestroyed;
        }

        public override void Enter()
        {
            if (_isDestroyed)
            {
                Console.WriteLine("Стена разрушена");
            }
            else
            {
                base.Enter();
            }
        }
        public override Wall Clone()
        {
            return new WallWithBomb();
        }
    }
}
