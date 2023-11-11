using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTest
{
    [TestClass]
    public class BLL_DANGKYTests
    {
        private Mock<IDAL_DANGKY> mockDangKyDAL;
        private BLL_DANGKY dangKyBLL;

        [TestInitialize]
        public void Setup()
        {
            mockDangKyDAL = new Mock<IDAL_DANGKY>();
            dangKyBLL = new BLL_DANGKY(mockDangKyDAL.Object);
        }

        [TestMethod]
        public void LayDanhSachDangKy_ShouldReturnCorrectResult()
        {
            // Arrange
            var expectedResult = new List<object>();
            mockDangKyDAL
                .Setup(x => x.LayDanhSachDangKy())
                .Returns(expectedResult);

            // Act
            dynamic result = dangKyBLL.LayDanhSachDangKy();

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DangKyKhamBenh_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            // Arrange
            var mockDangKy = new Mock<DANGKY>();
            mockDangKyDAL
                .Setup(x => x.DangKyKhamBenh(mockDangKy.Object))
                .Verifiable();

            // Act
            bool result = dangKyBLL.DangKyKhamBenh(mockDangKy.Object);

            // Assert
            Assert.IsTrue(result);
            mockDangKyDAL.Verify();
        }

        [TestMethod]
        public void DangKyKhamBenh_ShouldReturnFalse_WhenRegistrationFails()
        {
            // Arrange
            var mockDangKy = new Mock<DANGKY>();
            mockDangKyDAL
                .Setup(x => x.DangKyKhamBenh(mockDangKy.Object))
                .Throws(new Exception("Simulated exception"));

            // Act
            bool result = dangKyBLL.DangKyKhamBenh(mockDangKy.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void XoaDangKy_ShouldCallXoaDangKyMethod()
        {
            // Arrange
            var mockDangKy = new Mock<DANGKY>();
            mockDangKyDAL
                .Setup(x => x.XoaDangKy(mockDangKy.Object))
                .Verifiable();

            // Act
            dangKyBLL.XoaDangKy(mockDangKy.Object);

            // Assert
            mockDangKyDAL.Verify();
        }

        [TestMethod]
        public void LayDangKy_ShouldReturnCorrectResult()
        {
            // Arrange
            var idBenhNhan = 1;
            var expectedResult = new DANGKY();
            mockDangKyDAL
                .Setup(x => x.LayDangKy(idBenhNhan))
                .Returns(expectedResult);

            // Act
            DANGKY result = dangKyBLL.LayDangKy(idBenhNhan);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void LaySoBenhNhanTiepNhan_ShouldReturnCorrectResult()
        {
            // Arrange
            var expectedResult = 5;
            mockDangKyDAL
                .Setup(x => x.LaySoBenhNhanTiepNhan())
                .Returns(expectedResult);

            // Act
            int result = dangKyBLL.LaySoBenhNhanTiepNhan();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
