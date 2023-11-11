using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using DAL;
using DTO;
using BLL;

namespace UnitTest
{
    [TestClass] 
    public class BLL_CTPHIEUKHAMBENHTests
    {
        [TestMethod]
        public void ThemCTPKB_ShouldReturnTrue_WhenAdditionIsSuccessful()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var mockCTPKB = new Mock<CT_PHIEUKHAMBENH>();
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.ThemCTPKB(It.IsAny<CT_PHIEUKHAMBENH>()));

            // Act
            bool result = ctPhieuKhamBenhBLL.ThemCTPKB(mockCTPKB.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ThemCTPKB_ShouldReturnFalse_WhenAdditionFails()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var mockCTPKB = new Mock<CT_PHIEUKHAMBENH>();
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.ThemCTPKB(It.IsAny<CT_PHIEUKHAMBENH>()))
                .Throws(new Exception("Simulated exception during addition"));

            // Act
            bool result = ctPhieuKhamBenhBLL.ThemCTPKB(mockCTPKB.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LayDanhSachThuoc_ShouldReturnListOfThuoc()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var soPhieuKhamBenh = 1; 
            var mockThuocList = new List<THUOC>
        {
            new THUOC { },
            new THUOC { },
        };
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.LayDanhSachThuoc(soPhieuKhamBenh))
                .Returns(mockThuocList);

            // Act
            dynamic result = ctPhieuKhamBenhBLL.LayDanhSachThuoc(soPhieuKhamBenh);

            // Assert
            CollectionAssert.AreEqual(mockThuocList, result);
        }
        [TestMethod]
        public void SuaCTPKB_ShouldReturnTrue_WhenUpdateIsSuccessful()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var mockCTPKB = new Mock<CT_PHIEUKHAMBENH>();
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.SuaCTPKB(It.IsAny<CT_PHIEUKHAMBENH>()));

            // Act
            bool result = ctPhieuKhamBenhBLL.SuaCTPKB(mockCTPKB.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SuaCTPKB_ShouldReturnFalse_WhenUpdateFails()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var mockCTPKB = new Mock<CT_PHIEUKHAMBENH>();
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.SuaCTPKB(It.IsAny<CT_PHIEUKHAMBENH>()))
                .Throws(new Exception("Simulated exception during update"));

            // Act
            bool result = ctPhieuKhamBenhBLL.SuaCTPKB(mockCTPKB.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void XoaCTPKB_ShouldReturnTrue_WhenDeletionIsSuccessful()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var mockCTPKB = new Mock<CT_PHIEUKHAMBENH>();
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.XoaCTPKB(It.IsAny<CT_PHIEUKHAMBENH>()));

            // Act
            bool result = ctPhieuKhamBenhBLL.XoaCTPKB(mockCTPKB.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void XoaCTPKB_ShouldReturnFalse_WhenDeletionFails()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var mockCTPKB = new Mock<CT_PHIEUKHAMBENH>();
            mockCTPhieuKhamBenhDAL
                .Setup(x => x.XoaCTPKB(It.IsAny<CT_PHIEUKHAMBENH>()))
                .Throws(new Exception("Simulated exception during deletion"));

            // Act
            bool result = ctPhieuKhamBenhBLL.XoaCTPKB(mockCTPKB.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LayTheoThuoc_ShouldReturnCorrectResult()
        {
            // Arrange
            var mockCTPhieuKhamBenhDAL = new Mock<IDAL_CTPHIEUKHAMBENH>();
            var ctPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH(mockCTPhieuKhamBenhDAL.Object);
            var idThuoc = 1;
            var expectedResult = new List<CT_PHIEUKHAMBENH>
        {
            new CT_PHIEUKHAMBENH {},
            new CT_PHIEUKHAMBENH {},
        };

            mockCTPhieuKhamBenhDAL
                .Setup(x => x.LayTheoThuoc(idThuoc))
                .Returns(expectedResult);

            // Act
            dynamic result = ctPhieuKhamBenhBLL.LayTheoThuoc(idThuoc);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
