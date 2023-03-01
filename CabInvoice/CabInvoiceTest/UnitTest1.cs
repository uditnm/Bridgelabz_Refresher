using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenRides_returnTotalFare()
        {
            CabInvoice c = new CabInvoice();
            var rides = new List<(float,float)> { (12, 5), (5, 3) };
            float fare = c.CalculateFare(rides);
            Assert.AreEqual(178,fare);
        }

        [TestMethod]
        public void GivenRides_returnAverageFare()
        {
            CabInvoice c = new CabInvoice();
            var rides = new List<(float, float)> { (12, 5), (5, 3) };
            float fare = c.CalculateFare(rides);
            Assert.AreEqual(2, c.TotalRides());
        }

        [TestMethod]
        public void GivenRides_returnNumberofRides()
        {
            CabInvoice c = new CabInvoice();
            var rides = new List<(float, float)> { (12, 5), (5, 3) };
            float fare = c.CalculateFare(rides);
            Assert.AreEqual(89, c.AverageFare());
        }

        [TestMethod]
        public void GivenUserId_returnRide()
        {
            CabInvoice c = new CabInvoice();
            var rides = new List<(float, float)> { (12, 5), (5, 3) };
            float fare = c.CalculateFare(rides);
            Assert.AreEqual(c.RetrieveRides(2),(5,3));
        }


    }
}