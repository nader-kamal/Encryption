using Encryption.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryption.Library.Tests
{
    [TestClass]
    public class CaesarCipherTests
    {
        [TestMethod]
        public void Test_EcreyptChar()
        {
            //Arrange
            char Expected = 'S';
            char ch = 'N';
            int shift = 5;
            //Act
            CaesarCipher caesarCipher = new CaesarCipher();
            char Actual = caesarCipher.EcreyptChar(ch, shift);
            //Assert

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod()]
        public void Test_EcreyptText()
        {
            //Arrange
            string Expected = "SFIJW";
            string input = "NADER";
            int shift = 5;
            //Act
            CaesarCipher caesarCipher = new CaesarCipher();
            string Actual = caesarCipher.EcreyptText(input, shift);
            //Assert

            Assert.AreEqual(Expected, Actual);
        }
    }
}
