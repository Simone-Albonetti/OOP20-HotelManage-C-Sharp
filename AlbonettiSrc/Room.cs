namespace AlbonettiSrc
{
    public class Room
    {
        private int roomNumber;
        private RoomType type;

        public Room(int roomNumber, RoomType type)
        {
            this.roomNumber = roomNumber;
            this.type = type;
        }

        public int RoomNumber
        {
            get { return this.roomNumber; }
            set { this.roomNumber = value; }
        }

        public RoomType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
