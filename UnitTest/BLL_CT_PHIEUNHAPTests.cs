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
    public class BLL_CT_PHIEUNHAPTests
    {
        private Mock<IDAL_CTPHIEUNHAP> mockCTPhieuNhapDAL;
        private BLL_CT_PHIEUNHAP ctPhieuNhapBLL;

        [TestInitialize]
        public void Setup()
        {
            mockCTPhieuNhapDAL = new Mock<IDAL_CTPHIEUNHAP>();
            ctPhieuNhapBLL = new BLL_CT_PHIEUNHAP(mockCTPhieuNhapDAL.Object);
        }
        [TestMethod]
        public void GetCTByMa_ShouldReturnCorrectResult()
        {
            // Arrange
            var ma = 1;
            var expectedResult = new List<CT_PHIEUNHAP>
        {
            new CT_PHIEUNHAP {},
            new CT_PHIEUNHAP {},
        };

            mockCTPhieuNhapDAL
                .Setup(x => x.GetCTByMa(ma))
                .Returns(expectedResult);

            // Act
            List<CT_PHIEUNHAP> result = ctPhieuNhapBLL.GetCTByMa(ma);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ThemChiTietPhieu_ShouldReturnTrue_WhenAddingDetailIsSuccessful()
        {
            // Arrange
            var mockModel = new Mock<CT_PHIEUNHAP>();
            mockCTPhieuNhapDAL
                .Setup(x => x.ThemChiTietPhieu(mockModel.Object))
                .Returns(true);

            // Act
            bool result = ctPhieuNhapBLL.ThemChiTietPhieu(mockModel.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetDataCTPhieuByMaPhieu_ShouldReturnCorrectResult()
        {
            // Arrange
            var maPhieu = 1;
            var expectedResult = new object();
            mockCTPhieuNhapDAL
                .Setup(x => x.GetDataCTPhieuByMaPhieu(maPhieu))
                .Returns(expectedResult);

            // Act
            object result = ctPhieuNhapBLL.GetDataCTPhieuByMaPhieu(maPhieu);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void XoaChiTietPhieu_ShouldReturnTrue_WhenDeletionIsSuccessful()
        {
            // Arrange
            var mockModel = new Mock<CT_PHIEUNHAP>();
            mockCTPhieuNhapDAL
                .Setup(x => x.XoaChiTietPhieu(mockModel.Object))
                .Returns(true);

            // Act
            bool result = ctPhieuNhapBLL.XoaChiTietPhieu(mockModel.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SuaChiTietPhieu_ShouldReturnTrue_WhenUpdateIsSuccessful()
        {
            // Arrange
            var mockModel = new Mock<CT_PHIEUNHAP>();
            mockCTPhieuNhapDAL
                .Setup(x => x.SuaChiTietPhieu(mockModel.Object))
                .Returns(true);

            // Act
            bool result = ctPhieuNhapBLL.SuaChiTietPhieu(mockModel.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void XoaAllChiTietPhieu_ShouldReturnTrue_WhenDeletionIsSuccessful()
        {
            // Arrange
            var soPhieu = 1;
            mockCTPhieuNhapDAL
                .Setup(x => x.XoaAllChiTietPhieu(soPhieu))
                .Returns(true);

            // Act
            bool result = ctPhieuNhapBLL.XoaAllChiTietPhieu(soPhieu);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Getall_ShouldReturnCorrectResult()
        {
            // Arrange
            var i = 1;
            var expectedResult = new List<CT_PHIEUNHAP>();
            mockCTPhieuNhapDAL
                .Setup(x => x.Getall(i))
                .Returns(expectedResult);

            // Act
            dynamic result = ctPhieuNhapBLL.Getall(i);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
