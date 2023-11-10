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
    public class BLL_BENHTests
    {
        private Mock<IDAL_BENH> dBenhDALMock;
        private BLL_BENH bBenhBLL;
        [TestInitialize]
        public void Setup()
        {
            dBenhDALMock = new Mock<IDAL_BENH>();
            bBenhBLL = new BLL_BENH(dBenhDALMock.Object);
        }
        [TestMethod]
        public void LayThongTinBenh_ReturnsDynamicData()
        {
            // Arrange
            var expectedResult = new List<dynamic>() {  
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 } 
            };
            dBenhDALMock.Setup(dal => dal.LayThongTinBenh()).Returns(expectedResult);

            // Act
            var result = bBenhBLL.LayThongTinBenh();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Test_CapNhatBenh_ExistingBenh_ReturnsTrue()
        {
            // Arrange
            var benh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };

            dBenhDALMock.Setup(m => m.KiemTraBenh(benh)).Returns(true);

            // Act
            var result = bBenhBLL.CapNhatBenh(benh);

            // Assert
            Assert.IsTrue(result);
            dBenhDALMock.Verify(m => m.CapNhatBenh(benh), Times.Once);
        }
        [TestMethod]
        public void Test_CapNhatBenh_NonExistingBenh_ReturnsFalse()
        {
            // Arrange
            var benh = new BENH() { MaBenh = "B789", TenBenh = "Benh C", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dBenhDALMock.Setup(dal => dal.KiemTraBenh(benh)).Returns(false);

            // Act
            var result = bBenhBLL.CapNhatBenh(benh);

            // Assert
            Assert.IsFalse(result);
            dBenhDALMock.Verify(dal => dal.CapNhatBenh(benh), Times.Never);
        }
        [TestMethod]
        public void Test_ThemBenh_ValidBenh_ReturnsTrue()
        {
            // Arrange
            var benh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };

            // Act
            var result = bBenhBLL.ThemBenh(benh);

            // Assert
            Assert.IsTrue(result);
            dBenhDALMock.Verify(dal => dal.ThemBenh(benh), Times.Once);
        }
        [TestMethod]
        public void ThemBenh_ExceptionThrown_ReturnsFalse()
        {
            // Arrange
            var benh = new BENH() { /* Thông tin giả lập của bệnh */ };
            dBenhDALMock.Setup(dal => dal.ThemBenh(benh)).Throws(new Exception());

            // Act
            var result = bBenhBLL.ThemBenh(benh);

            // Assert
            Assert.IsFalse(result);
            dBenhDALMock.Verify(dal => dal.ThemBenh(benh), Times.Once);
        }
        [TestMethod]
        public void XoaBenh_ExistingBenh_ReturnsTrue()
        {
            // Arrange
            var benh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dBenhDALMock.Setup(dal => dal.KiemTraBenh(benh)).Returns(true);

            // Act
            var result = bBenhBLL.XoaBenh(benh);

            // Assert
            Assert.IsTrue(result);
            dBenhDALMock.Verify(dal => dal.XoaBenh(benh), Times.Once);
        }
        [TestMethod]
        public void XoaBenh_NonExistingBenh_ReturnsFalse()
        {
            // Arrange
            var benh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dBenhDALMock.Setup(dal => dal.KiemTraBenh(benh)).Returns(false);

            // Act
            var result = bBenhBLL.XoaBenh(benh);

            // Assert
            Assert.IsFalse(result);
            dBenhDALMock.Verify(dal => dal.XoaBenh(benh), Times.Never);
        }
        [TestMethod]
        public void LayBenh_ByMaBenh_ReturnsCorrectBenh()
        {
            // Arrange
            var maBenh = "B3";
            var expectedBenh = new BENH() { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dBenhDALMock.Setup(dal => dal.LayBenh(maBenh)).Returns(expectedBenh);

            // Act
            var result = bBenhBLL.LayBenh(maBenh);

            // Assert
            Assert.AreEqual(expectedBenh, result);
            dBenhDALMock.Verify(m => m.LayBenh(maBenh), Times.Once);
        }
        [TestMethod]
        public void LayBenh_ByIdBenh_ReturnsCorrectBenh()
        {
            // Arrange
            var idBenh = 1;
            var expectedBenh = new BENH() { id = 1, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dBenhDALMock.Setup(dal => dal.LayBenh(idBenh)).Returns(expectedBenh);

            // Act
            var result = bBenhBLL.LayBenh(idBenh);

            // Assert
            Assert.AreEqual(expectedBenh, result);
            dBenhDALMock.Verify(m => m.LayBenh(idBenh), Times.Once);
        }
        [TestMethod]
        public void LocBenh_ExistingKieuLoc_ReturnsMatchingData()
        {
            // Arrange
            var kieuLoc = "Tên bệnh";
            var giaTri = "Benh 3";
            var expectedResult = new List<dynamic>() {
                new BENH() { id = 1, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 }
            };
            dBenhDALMock.Setup(dal => dal.LocBenh(kieuLoc, giaTri)).Returns(expectedResult);

            // Act
            var result = bBenhBLL.LocBenh(kieuLoc, giaTri);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
