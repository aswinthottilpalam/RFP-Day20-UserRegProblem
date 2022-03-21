using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFP_day20_UserRegProblem;
using System; 

namespace UserRegTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }

        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Aswin";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Thottilpalam";
            bool result = program.LastNameVal(name);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void EmailTest()
        {
            string email1 = "aswin@gmail.com";
            string email2 = "aswin009@gmail.com";
            string email3 = "abc@xyz.com";
            string email4 = "aswin1234@xyz.com";
            string email5 = "thottilpalam@abc.com";
            bool result = program.EmailValidation(email1);
            bool result2 = program.EmailValidation(email2);
            bool result3 = program.EmailValidation(email3);
            bool result4 = program.EmailValidation(email4);
            bool result5 = program.EmailValidation(email5);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 9876543210";
            bool result = program.MobileValidation(mobile);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PasswordTest()
        {
            string password = "aswin@999";
            bool result = program.PasswordRule(password);
            Assert.AreEqual(true, result);
        }
    }
}
