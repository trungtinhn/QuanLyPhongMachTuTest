using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class BLL_PHIEUNHAPTHUOCTests
    {
        private BLL_PHIEUNHAPTHUOC pHIEUNHAPTHUOC;
        private Mock<IDAL_PHIEUNHAPTHUOC> idal;
        [TestInitialize]
        public void SetUp()
        {
            idal = new Mock<IDAL_PHIEUNHAPTHUOC> ();
            pHIEUNHAPTHUOC = new BLL_PHIEUNHAPTHUOC(idal.Object);
        }
        [TestMethod]
        public void GetData_ReturnsListOfPhieuNhapThuoc()
        {
            // Arrange
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 2, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            List<PHIEUNHAPTHUOC> expectedData = new List<PHIEUNHAPTHUOC>() { phieuNhap1, phieuNhap2 };
            idal.Setup(dal => dal.GetData()).Returns(expectedData);

            // Act
            List<PHIEUNHAPTHUOC> actualData = pHIEUNHAPTHUOC.GetData();

            // Assert
            Assert.AreEqual(expectedData, actualData);
        }
        [TestMethod]
        public void GetDataByMa_ReturnsPhieuNhapThuoc()
        {
            // Arrange
            int maPhieu = 1;
            PHIEUNHAPTHUOC expectedPhieuNhapThuoc = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 100, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            idal.Setup(dal => dal.GetDataByMa(maPhieu)).Returns(expectedPhieuNhapThuoc);

            // Act
            PHIEUNHAPTHUOC actualPhieuNhapThuoc = pHIEUNHAPTHUOC.GetDataByMa(maPhieu);

            // Assert
            Assert.AreEqual(expectedPhieuNhapThuoc, actualPhieuNhapThuoc);
        }
        [TestMethod]
        public void GetMaMax_ReturnsMaxMaPhieu()
        {
            // Arrange
            int expectedMaxMaPhieu = 10;
            idal.Setup(dal => dal.GetMaMax()).Returns(expectedMaxMaPhieu);

            // Act
            int actualMaxMaPhieu = pHIEUNHAPTHUOC.GetMaMax();

            // Assert
            Assert.AreEqual(expectedMaxMaPhieu, actualMaxMaPhieu);
        }
        [TestMethod]
        public void ThemPhieuNhapThuoc_ReturnTrue()
        {
            // Arrange
            PHIEUNHAPTHUOC phieu = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            idal.Setup(dal => dal.ThemPhieu(phieu)).Returns(true);

            // Act
            var result = pHIEUNHAPTHUOC.ThemPhieu(phieu);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void XoaPhieuNhap_ReturnsTrue()
        {
            // Arrange
            int soPhieu = 1;
            idal.Setup(dal => dal.XoaPhieuNhap(soPhieu)).Returns(true);

            // Act
            bool result = pHIEUNHAPTHUOC.XoaPhieuNhap(soPhieu);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TongTien_ReturnsInt()
        {
            int maPhieu = 1;
            int expectedTotalAmount = 100;
            idal.Setup(dal => dal.TongTien(maPhieu)).Returns(expectedTotalAmount);

            // Act
            int actualTotalAmount = pHIEUNHAPTHUOC.TongTien(maPhieu);

            // Assert
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }
        [TestMethod]
        public void GetTongtien_ReturnsTotalAmount()
        {
            // Arrange
            PHIEUNHAPTHUOC phieu = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 100, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            int expectedTotalAmount = 100;
            idal.Setup(dal => dal.getTongtien(phieu)).Returns(expectedTotalAmount);

            // Act
            int actualTotalAmount = pHIEUNHAPTHUOC.getTongtien(phieu);

            // Assert
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }
        [TestMethod]
        public void LuuPhieuNhapThuoc_ReturnsTrue()
        {
            // Arrange
            PHIEUNHAPTHUOC pnt = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 100, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            idal.Setup(dal => dal.LuuPhieuNhapThuoc(pnt)).Returns(true);

            // Act
            bool result = pHIEUNHAPTHUOC.LuuPhieuNhapThuoc(pnt);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
