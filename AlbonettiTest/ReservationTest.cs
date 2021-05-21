using AlbonettiSrc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TozziSrc;

namespace AlbonettiTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void TestCreateReservation()
        {
            Client client = new Client("Simone.Albonetti.LBN");
            DateTime dateIn = new DateTime(2021, 05, 21);
            DateTime dateOut = new DateTime(2021, 05, 25);
            RoomController roomController = new RoomController();
            Reservation reservation = new Reservation(client, dateIn, dateOut, roomController.GetRoom(2));
            Assert.IsTrue(reservation != null);
            Console.WriteLine(reservation);

            Assert.AreNotEqual(new Client("Chiara.Tozzi.TZZ"), reservation.Client);
            Assert.AreEqual(RoomType.SINGLE, reservation.Room.Type);
        }
    }
}
