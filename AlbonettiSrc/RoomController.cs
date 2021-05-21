using System;
using System.Collections.Generic;
using System.Text;

namespace AlbonettiSrc
{
    public class RoomController
    {
        private readonly int SINGLEROOMNUMBER = 5;
        private readonly int DOUBLEROOMNUMBER = 5;
        private readonly int TRIPLEROOMNUMBER = 5;
        private readonly int QUARTUPLEROOMNUMBER = 5;
        private readonly int SUITEROOMNUMBER = 1;

        private readonly List<Room> rooms = new List<Room>();


        private void Initialize()
        {
            int counter = 1;
            for (; counter <= SINGLEROOMNUMBER; counter++)
            {
                Room room = new Room(counter, RoomType.SINGLE);
                this.rooms.Add(room);
            }
            for (; counter <= SINGLEROOMNUMBER + DOUBLEROOMNUMBER; counter++)
            {
                Room room = new Room(counter, RoomType.DOUBLE);
                this.rooms.Add(room);
            }
            for (; counter <= SINGLEROOMNUMBER + DOUBLEROOMNUMBER + TRIPLEROOMNUMBER; counter++)
            {
                Room room = new Room(counter, RoomType.TRIPLE);
                this.rooms.Add(room);
            }
            for (; counter <= SINGLEROOMNUMBER + DOUBLEROOMNUMBER + TRIPLEROOMNUMBER + QUARTUPLEROOMNUMBER; counter++)
            {
                Room room = new Room(counter, RoomType.QUARTUPLE);
                this.rooms.Add(room);
            }

            for (; counter <= SINGLEROOMNUMBER + DOUBLEROOMNUMBER + TRIPLEROOMNUMBER + QUARTUPLEROOMNUMBER + SUITEROOMNUMBER ; counter++)
            {
                Room room = new Room(counter, RoomType.SUITE);
                this.rooms.Add(room);
            }
        }

        public RoomController()
        {
            this.Initialize();
        }

        public List<Room> GetRooms()
        {
            return this.rooms;
        }

        public Room GetRoom(int roomNumber)
        {
            return this.rooms[roomNumber-1];
        }
    }
}
