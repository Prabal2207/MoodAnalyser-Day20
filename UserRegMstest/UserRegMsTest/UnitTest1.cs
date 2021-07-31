using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAY20;

namespace UserRegMsTest
{
    [TestClass]
    public class UnitTest1
    {

        //UC1
        [TestMethod]
        public void UserFirstName()
        {
            var result = UserRegistration.ValidateFirstName("Prabal");
            Assert.AreEqual(true, result);
        }

        //UC2

        [TestMethod]
        public void UserLastName()
        {
            var result = UserRegistration.ValidateLastName("Rai");
            Assert.AreEqual(true, result);
        }


        //UC3
        [TestMethod]
        public void UserEmail()
        {
            var result = UserRegistration.Validateemail("prabal760@gmail.com");
            Assert.AreEqual(true, result);
        }


        //UC4
        [TestMethod]
        public void UserPhoneNumber()
        {
            var result = UserRegistration.ValidatePhoneNumber("91 7022150443");
            Assert.AreEqual(true, result);
        }


        //UC5
        [TestMethod]
        public void UserPassword()
        {
            var result = UserRegistration.ValidatePassword("PrabQE@123");
            Assert.AreEqual(true, result);
        }

    }
}
