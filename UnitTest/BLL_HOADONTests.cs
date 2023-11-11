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
    public class BLL_HOADONTests
    {
        private Mock<IDAL_HOADON> mockHoaDonDAL;
        private BLL_HOADON hoaDonBLL;

        [TestInitialize]
        public void Setup()
        {
            mockHoaDonDAL = new Mock<IDAL_HOADON>();
            hoaDonBLL = new BLL_HOADON(mockHoaDonDAL.Object);
        }

        [TestMethod]
        public void TaoHoaDon_ShouldReturnTrue_WhenCreatingInvoiceIsSuccessful()
        {
            // Arrange
            var mockHoaDon = new Mock<HOADON>();
            mockHoaDonDAL
                .Setup(x => x.TaoHoaDon(mockHoaDon.Object))
                .Verifiable();

            // Act
            bool result = hoaDonBLL.TaoHoaDon(mockHoaDon.Object);

            // Assert
            Assert.IsTrue(result);
            mockHoaDonDAL.Verify();
        }

        [TestMethod]
        public void TaoHoaDon_ShouldReturnFalse_WhenCreatingInvoiceFails()
        {
            // Arrange
            var mockHoaDon = new Mock<HOADON>();
            mockHoaDonDAL
                .Setup(x => x.TaoHoaDon(mockHoaDon.Object))
                .Throws(new Exception("Simulated exception"));

            // Act
            bool result = hoaDonBLL.TaoHoaDon(mockHoaDon.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LayDanhSachHoaDon_ShouldReturnCorrectResult()
        {
            // Arrange
            var idBenhNhan = 1;
            var expectedResult = new List<HOADON>();
            mockHoaDonDAL
                .Setup(x => x.LayDanhSachHoaDon(idBenhNhan))
                .Returns(expectedResult);

            // Act
            dynamic result = hoaDonBLL.LayDanhSachHoaDon(idBenhNhan);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void LayHoaDon_ShouldReturnCorrectResult()
        {
            // Arrange
            var soPhieuKhamBenh = 1;
            var expectedResult = new HOADON();
            mockHoaDonDAL
                .Setup(x => x.LayHoaDon(soPhieuKhamBenh))
                .Returns(expectedResult);

            // Act
            HOADON result = hoaDonBLL.LayHoaDon(soPhieuKhamBenh);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CapNhatThanhToan_ShouldCallUpdatePaymentMethod()
        {
            // Arrange
            var id = 1;
            mockHoaDonDAL
                .Setup(x => x.CapNhatThanhToan(id))
                .Verifiable();

            // Act
            hoaDonBLL.CapNhatThanhToan(id);

            // Assert
            mockHoaDonDAL.Verify();
        }

        [TestMethod]
        public void TongDoanhThuNgay_ShouldReturnCorrectResult()
        {
            // Arrange
            var ngay = 1;
            var thang = 2;
            var nam = 2023;
            var expectedResult = 1000;
            mockHoaDonDAL
                .Setup(x => x.TongDoanhThuNgay(ngay, thang, nam))
                .Returns(expectedResult);

            // Act
            int result = hoaDonBLL.TongDoanhThuNgay(ngay, thang, nam);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
