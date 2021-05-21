using AlbonettiSrc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlbonettiTest
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void CreateRoom()
        {
            Room room = new Room(5, RoomType.SINGLE);
            Assert.IsFalse(room == null);
            Console.WriteLine(room);
        }

        [TestMethod]
        public void TestControllerRoom()
        {
            RoomController roomController = new RoomController();
            Assert.AreEqual(21, roomController.GetRooms().Count);
            Assert.AreEqual(5, roomController.GetRoom(5).RoomNumber);
            Assert.AreEqual(RoomType.SUITE, roomController.GetRoom(21).Type);
        }

        [TestMethod]
        public void TestRoomType()
        {
            Assert.IsFalse(RoomType.SINGLE.Beds == 2);
            Assert.IsTrue(RoomType.QUARTUPLE.Beds == 4);
            Assert.IsTrue(RoomType.SUITE.Price == 100);
        }

    }
}
