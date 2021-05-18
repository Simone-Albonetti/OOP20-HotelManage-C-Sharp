using System.Collections.Generic;

namespace AlbonettiSrc
{
    public class RoomType
    {
        public static readonly RoomType SINGLE = new RoomType("Single", 25, 1);
        public static readonly RoomType DOUBLE = new RoomType("Double", 35, 2);
        public static readonly RoomType TRIPLE = new RoomType("Triple", 45, 3);
        public static readonly RoomType QUARTUPLE = new RoomType("Quartuple", 60, 4);
        public static readonly RoomType SUITE = new RoomType("Suite", 100, 2);

        public static IEnumerable<RoomType> Values
        {
            get
            {
                yield return SINGLE;
                yield return DOUBLE;
                yield return TRIPLE;
                yield return QUARTUPLE;
                yield return SUITE;
            }
        }

        public double Price { get; private set; }
        public int Beds { get; private set; }

        public string NameType { get; private set; }

        RoomType(string nameType, double price, int beds)
        {
            this.Price = price;
            this.Beds = beds;
            this.NameType = nameType;
        }

        public override string ToString()
        {
            return "RoomType:\nNameType: " + this.NameType + "\t\tPrice: " + this.Price + "\t\tBeds" + this.Beds;
        }
    }

}
