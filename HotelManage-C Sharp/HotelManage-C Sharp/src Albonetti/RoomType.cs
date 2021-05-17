using System.Collections.Generic;

public class RoomType
{


    public static void Main()
    {
    }
    public static readonly RoomType SINGLE = new RoomType(25, 1);
    public static readonly RoomType DOUBLE = new RoomType(35, 2);
    public static readonly RoomType TRIPLE = new RoomType(45, 3);
    public static readonly RoomType QUARTUPLE = new RoomType(60, 4);
    public static readonly RoomType SUITE = new RoomType(100, 2);

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

    RoomType(double price, int beds)
    {
        this.Price = price;
        this.Beds = beds;
    }
}
