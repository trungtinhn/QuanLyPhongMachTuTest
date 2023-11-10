using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using DTO;
using BLL;

namespace UnitTest
{
    [TestClass]
    public class BLL_LOGINTests
    {
        private Mock<IDAL_LOGIN> dalLoginMock;
        private BLL_LOGIN bLoginBLL;
        [TestInitialize]
        public void SetUp()
        {
            dalLoginMock = new Mock<IDAL_LOGIN>();
            bLoginBLL = new BLL_LOGIN(dalLoginMock.Object);
        }
        [TestMethod]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            //Arrange
            dalLoginMock.Setup(x => x.Login("testuser", "testpassword")).Returns(true);
            //Act
            bool result = bLoginBLL.Login("testuser", "testpassword");
            //Assert
            dalLoginMock.Verify(x => x.Login("testuser", "testpassword"), Times.Once);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Login_InValidCredentials_ReturnsFalse()
        {
            //Arrange
            dalLoginMock.Setup(x => x.Login("testuser", "testpassword")).Returns(false);
            //Act
            bool result = bLoginBLL.Login("testuser", "testpassword");
            //Assert
            dalLoginMock.Verify(x => x.Login("testuser", "testpassword"), Times.Once);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Check_ExistingUsername_ReturnsTrue()
        {
            //Arrange
            dalLoginMock.Setup(x => x.Check("testuser")).Returns(true);

            //Act
            bool result = bLoginBLL.Check("testuser");

            //Assert
            dalLoginMock.Verify(x => x.Check("testuser"), Times.Once);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_NotExistingUsername_ReturnsFalse()
        {
            //Arrange
            dalLoginMock.Setup(x => x.Check("testuser")).Returns(false);

            //Act
            bool result = bLoginBLL.Check("testuser");

            //Assert
            dalLoginMock.Verify(x => x.Check("testuser"), Times.Once);
            Assert.IsFalse(result);
        }
    }
}
