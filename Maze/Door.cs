using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Door : IMapSite
    {
        private static Random Rnd = new Random();
        private readonly bool _isOpen;
        private Room _room1;
        private Room _room2;
        public Door (Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException($"Комнаты {room1.Number} не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException($"Комнаты {room2.Number} не существует");
            }
            _isOpen = Rnd.Next(2) == 0;
            _room1 = room1;
            _room2 = room2;
        }
        public Room OtherSideFrom(Room room)
        {
            if (room == _room1)
            {
                return _room2;
            }
            else if (room == _room2)
            {
                return _room1;
            }
            else
            {
                throw new ArgumentException(nameof(room), "Комнаты не существует");
            }
        }
        public virtual void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Вы прошли через дверь");
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }
        public Door Clone()
        {
            return new Door(_room1.Clone(), _room2.Clone());
        }
        public void Initialize(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException($"Комнаты {room1.Number} не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException($"Комнаты {room2.Number} не существует");
            }
            _room1 = room1;
            _room2 = room2;
        }
    }
}
