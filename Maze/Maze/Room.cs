using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Room : IMapSite
    {
        internal int Number { get; private set; }
        private IMapSite[] _sides = new IMapSite[4];
        public Room(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            Number = roomNumber;
        }
        public IMapSite GetSide(Direction dir)
        {
            return _sides[(int)dir];
        }
        public void SetSide(Direction dir, IMapSite side)
        {
            _sides[(int)dir] = side;
        }
        public virtual void Enter()
        {
            Console.WriteLine($"Вы в комнате {Number}");
        }
        public virtual Room Clone()
        {
            return new Room(Number);
        }
        public void Initialize(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            Number = roomNumber;
        }
    }
}
