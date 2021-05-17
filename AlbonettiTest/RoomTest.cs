using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlbonettiSrc;

namespace AlbonettiTest
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void CreateRoom()
        {
            Room room = new Room(5, RoomType.SINGLE);
        }
    }
}
