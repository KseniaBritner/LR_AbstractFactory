using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Mazze
    {
        private readonly Dictionary<int, Room> _rooms = new Dictionary<int, Room>();
        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException(nameof(room), "Комнаты не существует");
            }
            _rooms[room.Number] = room;
        }
        public Room RoomNo(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не существует");
            }
            return _rooms.ContainsKey(roomNumber) ? _rooms[roomNumber] : null;
        }
        public Mazze Clone()
        {
            return new Mazze(); 
        }
    }
}
