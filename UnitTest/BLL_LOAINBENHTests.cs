using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class BLL_LOAINBENHTests
    {
        private Mock<IDAL_LOAIBENH> mockDal;
        private BLL_LOAIBENH bLL_LOAIBENH;
        [TestInitialize]
        public void SetUp()
        {
            mockDal = new Mock<IDAL_LOAIBENH>();
            bLL_LOAIBENH = new BLL_LOAIBENH(mockDal.Object);
        }
        [TestMethod]
        public void LayDanhSachLoaiBenh_KieuLocAll_ReturnsAllLoaiBenh()
        {
            // Arrange
            bLL_LOAIBENH = new BLL_LOAIBENH(mockDal.Object);
            var kieuLoc = "Tất cả";
            var giaTri = "";
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<dynamic> { loaiBenh1, loaiBenh2 };

            mockDal.Setup(dal => dal.LayDanhSachLoaiBenh(kieuLoc, giaTri)).Returns(danhSachLoaiBenh);
            // Act
            var result = bLL_LOAIBENH.LayDanhSachLoaiBenh(kieuLoc, giaTri);
            // Assert
            Assert.AreEqual(danhSachLoaiBenh, result);
        }
        [TestMethod]
        public void LayDanhSachLoaiBenh_KieuLocMaLoaiBenh_ReturnsListLoaiBenh()
        {
            // Arrange
            var kieuLoc = "Mã loại bệnh";
            var giaTri = "LB001";
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<dynamic> { loaiBenh1, loaiBenh2 };
            var expected = new List<dynamic> { loaiBenh1 };

            mockDal.Setup(dal => dal.LayDanhSachLoaiBenh(kieuLoc, giaTri)).Returns(expected);
            // Act
            var result = bLL_LOAIBENH.LayDanhSachLoaiBenh(kieuLoc, giaTri);
            // Assert
            Assert.AreEqual(expected.Count, result.Count);
        }
        [TestMethod]
        public void LayDanhSachLoaiBenh_KieuLocTenLoaiBenh_ReturnsListLoaiBenh()
        {

            // Arrange
            var kieuLoc = "Tên loại bệnh";
            var giaTri = "Loại bệnh 1";
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<dynamic> { loaiBenh1, loaiBenh2 };
            var expected = new List<dynamic> { loaiBenh1 };

            mockDal.Setup(dal => dal.LayDanhSachLoaiBenh(kieuLoc, giaTri)).Returns(expected);
            // Act
            var result = bLL_LOAIBENH.LayDanhSachLoaiBenh(kieuLoc, giaTri);
            // Assert
            Assert.AreEqual(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].TenLoaiBenh, result[i].TenLoaiBenh);
            }
        }
        [TestMethod]
        public void LayTenLoaiBenh_ValidMaBenh_ReturnsTenLoaiBenh()
        {
            // Arrange
            var id = 1;
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            mockDal.Setup(dal => dal.LayTenLoaiBenh(id)).Returns("Loại bệnh 1");
            // Act
            var result = bLL_LOAIBENH.LayTenLoaiBenh(id);
            // Assert
            Assert.AreEqual("Loại bệnh 1", result);
        }
        [TestMethod]
        public void ThemLoaiBenh_ValidLoaiBenh_ReturnTrue()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            // Act
            var result = bLL_LOAIBENH.ThemLoaiBenh(expectedBenh);

            // Assert
            Assert.IsTrue(result);
            mockDal.Verify(d => d.ThemLoaiBenh(expectedBenh), Times.Once);
        }
        [TestMethod]
        public void ThemLoaiBenh_ThrowsException_ReturnFalse()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            mockDal.Setup( d=> d.ThemLoaiBenh(expectedBenh)).Throws(new Exception());
            // Act
            var result = bLL_LOAIBENH.ThemLoaiBenh(expectedBenh);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CapNhatLoaiBenh_ValidLoaiBenh_ReturnTrue()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            mockDal.Setup(d => d.KiemTraLoaiBenh(expectedBenh)).Returns(true);

            // Act
            var result = bLL_LOAIBENH.CapNhatLoaiBenh(expectedBenh);

            // Assert
            Assert.IsTrue(result);
            mockDal.Verify(m => m.CapNhatLoaiBenh(expectedBenh), Times.Once);
        }
        [TestMethod]
        public void CapNhatLoaiBenh_NotValidLoaiBenh_ReturnFalse()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            mockDal.Setup(d => d.KiemTraLoaiBenh(expectedBenh)).Returns(false);

            // Act
            var result = bLL_LOAIBENH.CapNhatLoaiBenh(expectedBenh);

            // Assert
            Assert.IsFalse(result);
            mockDal.Verify(m => m.CapNhatLoaiBenh(expectedBenh), Times.Never);
        }
        [TestMethod]
        public void CapNhatLoaiBenh_ThrowsException_ReturnFalse()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            mockDal.Setup(d => d.KiemTraLoaiBenh(expectedBenh)).Returns(false);
            mockDal.Setup(d => d.CapNhatLoaiBenh(expectedBenh)).Throws(new DbUpdateException());
            // Act
            var result = bLL_LOAIBENH.CapNhatLoaiBenh(expectedBenh);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void XoaLoaiBenh_ExixtingLoaiBenh_ReturnTrue()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            mockDal.Setup(d => d.KiemTraLoaiBenh(expectedBenh)).Returns(true);

            // Act
            var result = bLL_LOAIBENH.XoaLoaiBenh(expectedBenh);

            // Assert
            Assert.IsTrue(result);
            mockDal.Verify(m => m.XoaLoaiBenh(expectedBenh), Times.Once);
        }
        [TestMethod]
        public void XoaLoaiBenh_NotExistingLoaiBenh_ReturnFalse()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            mockDal.Setup(d => d.KiemTraLoaiBenh(expectedBenh)).Returns(false);
            
            // Act
            var result = bLL_LOAIBENH.XoaLoaiBenh(expectedBenh);

            // Assert
            Assert.IsFalse(result);
            mockDal.Verify(m => m.XoaLoaiBenh(expectedBenh), Times.Never);
        }
        [TestMethod]
        public void XoaLoaiBenh_ThrowsException_ReturnFalse()
        {
            // Arrange
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            mockDal.Setup(d => d.KiemTraLoaiBenh(expectedBenh)).Returns(false);
            mockDal.Setup(d => d.XoaLoaiBenh(expectedBenh)).Throws(new DbUpdateException());

            // Act
            var result = bLL_LOAIBENH.XoaLoaiBenh(expectedBenh);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LayThongTinLoaiBenh_ExistingTenLoaiBenh_ReturnsLoaiBenh()
        {
            // Arrange
            string tenLb = "Loai Benh 1";
            var expectedBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = tenLb };
            mockDal.Setup(d => d.LayThongTinLoaiBenh(tenLb)).Returns(expectedBenh);
            // Act
            var result = bLL_LOAIBENH.LayThongTinLoaiBenh(tenLb);
            // Assert
            mockDal.Verify(d => d.LayThongTinLoaiBenh(tenLb), Times.Once);
            Assert.AreEqual(expectedBenh, result);
        }
        [TestMethod]
        public void LayThongTinLoaiBenh_NonExistingTenLoaiBenh_ReturnsNull()
        {
            // Arrange
            string tenLb = "Loai Benh 1";
            
            mockDal.Setup(d => d.LayThongTinLoaiBenh(tenLb)).Returns((LOAIBENH)null);
            // Act
            var result = bLL_LOAIBENH.LayThongTinLoaiBenh(tenLb);
            // Assert
            mockDal.Verify(d => d.LayThongTinLoaiBenh(tenLb), Times.Once);
            Assert.IsNull(result);
        }
    }
}
