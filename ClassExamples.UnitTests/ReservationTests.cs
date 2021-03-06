using ClassExamples.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassExamples.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_Scenario_ExpectedBehavior()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUser_ReturnTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_AnotherUser_ReturnFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };
            //Act
            var result = reservation.CanBeCancelledBy(new User());
            //Assert
            Assert.IsFalse(result);
        }
    }
}
