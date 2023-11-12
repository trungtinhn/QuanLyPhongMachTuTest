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
    public class BLL_PHIEUKHAMBENHTests
    {
        private Mock<IDAL_PHIEUKHAMBENH> mockPhieuKhamBenhDAL;
        private BLL_PHIEUKHAMBENH bLL_PHIEUKHAMBENH;

        [TestInitialize]
        public void TestInitialize()
        {
            mockPhieuKhamBenhDAL = new Mock<IDAL_PHIEUKHAMBENH>();
            bLL_PHIEUKHAMBENH = new BLL_PHIEUKHAMBENH(mockPhieuKhamBenhDAL.Object);
        }
        [TestMethod]
        public void ThemPhieuKhamBenh_ReturnsTrueWhenDALReturnsSuccessfully()
        {
            // Arrange
            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 1, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };

            mockPhieuKhamBenhDAL.Setup(dal => dal.ThemPhieuKhamBenh(pkb));

            // Act
            bool result = bLL_PHIEUKHAMBENH.ThemPhieuKhamBenh(pkb);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ThemPhieuKhamBenh_ReturnsFalseWhenDALThrowsException()
        {
            // Arrange
            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH();

            mockPhieuKhamBenhDAL.Setup(dal => dal.ThemPhieuKhamBenh(pkb))
                .Throws<Exception>();

            // Act
            bool result = bLL_PHIEUKHAMBENH.ThemPhieuKhamBenh(pkb);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LayDanhSachPhieuKhamBenh_CallsDALWithCorrectParameters()
        {
            // Arrange
            string kieuLoc = "Mã bệnh nhân";
            string giaTri = "123";
            DateTime start = new DateTime(2022, 1, 1);
            DateTime end = new DateTime(2022, 12, 31);

            mockPhieuKhamBenhDAL.Setup(dal => dal.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, start, end))
                .Returns(new List<PHIEUKHAMBENH>());

            // Act
            var result = bLL_PHIEUKHAMBENH.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, start, end);

            // Assert
            mockPhieuKhamBenhDAL.Verify(dal => dal.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, start, end), Times.Once);
        }
        [TestMethod]
        public void TinhTongTien_CallsDALWithCorrectParameter()
        {
            // Arrange
            int soPhieuKhamBenh = 123;

            // Act
            bLL_PHIEUKHAMBENH.TinhTongTien(soPhieuKhamBenh);

            // Assert
            mockPhieuKhamBenhDAL.Verify(dal => dal.TinhTongTien(soPhieuKhamBenh), Times.Once);
        }
        [TestMethod]
        public void LuuPhieuKhamBenh_ReturnsTrueWhenDALReturnsSuccessfully()
        {
            // Arrange
            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 1, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };

            mockPhieuKhamBenhDAL.Setup(dal => dal.LuuPhieuKhamBenh(pkb));

            // Act
            bool result = bLL_PHIEUKHAMBENH.LuuPhieuKhamBenh(pkb);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LuuPhieuKhamBenh_ReturnsFalseWhenDALThrowsException()
        {
            // Arrange
            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH();

            mockPhieuKhamBenhDAL.Setup(dal => dal.LuuPhieuKhamBenh(pkb))
                .Throws<Exception>();

            // Act
            bool result = bLL_PHIEUKHAMBENH.LuuPhieuKhamBenh(pkb);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LayPhieuKhamBenh_ById_ReturnsPhieuKhamBenh()
        {
            // Arrange
            int soPhieuKhamBenh = 123;
            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 123, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 1, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };

            mockPhieuKhamBenhDAL.Setup(dal => dal.LayPhieuKhamBenh(soPhieuKhamBenh))
                .Returns(pkb);

            // Act
            PHIEUKHAMBENH result = bLL_PHIEUKHAMBENH.LayPhieuKhamBenh(soPhieuKhamBenh);

            // Assert
            mockPhieuKhamBenhDAL.Verify(dal => dal.LayPhieuKhamBenh(soPhieuKhamBenh), Times.Once);
            Assert.AreEqual(pkb, result);
        }
    }
}
