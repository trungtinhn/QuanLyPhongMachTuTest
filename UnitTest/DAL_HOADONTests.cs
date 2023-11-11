using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class DAL_HOADONTests
    {
        private DAL_HOADON dalHoaDon;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<HOADON>> hoaDonDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            hoaDonDbSetMock = new Mock<DbSet<HOADON>>();
            dalHoaDon = new DAL_HOADON(dbContextMock.Object);

            // Thiết lập mock cho DbSet
            var hoaDonList = new List<HOADON>
        {
            new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" },
            new HOADON { SoHoaDon = 2, SoPhieuKhamBenh = 2, TienKham = 25000, TienThuoc = 60000, idBenhNhan = 1, TrangThai = "ChuaThanhToan" },
            //Thêm dữ liệu mẫu tương ứng với idBenhNhan khác nếu cần
        };

            hoaDonDbSetMock.As<IQueryable<HOADON>>().Setup(m => m.Provider).Returns(hoaDonList.AsQueryable().Provider);
            hoaDonDbSetMock.As<IQueryable<HOADON>>().Setup(m => m.Expression).Returns(hoaDonList.AsQueryable().Expression);
            hoaDonDbSetMock.As<IQueryable<HOADON>>().Setup(m => m.ElementType).Returns(hoaDonList.AsQueryable().ElementType);
            hoaDonDbSetMock.As<IQueryable<HOADON>>().Setup(m => m.GetEnumerator()).Returns(hoaDonList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.HOADONs).Returns(hoaDonDbSetMock.Object);
        }

        [TestMethod]
        public void LayDanhSachHoaDon_ShouldReturnListOfHoaDon_WhenIdBenhNhanIsValid()
        {
            // Arrange
            int idBenhNhan = 1;

            // Act
            var result = dalHoaDon.LayDanhSachHoaDon(idBenhNhan);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<HOADON>));
            Assert.AreEqual(2, result.Count); // Số lượng hoa đơn tương ứng với idBenhNhan trong dữ liệu mẫu.
        }
        [TestMethod]
        public void LayHoaDon_ShouldReturnHoaDon_WhenSoPhieuKhamBenhIsValid()
        {
            // Arrange
            int soPhieuKhamBenh = 1;

            // Act
            var result = dalHoaDon.LayHoaDon(soPhieuKhamBenh);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(HOADON));
            Assert.AreEqual(1, result.SoHoaDon); // Chỉ là một ví dụ, điều này sẽ phụ thuộc vào dữ liệu mẫu của bạn.
        }
        [TestMethod]
        public void CapNhatThanhToan_ShouldUpdateTrangThai_WhenIdIsValid()
        {
            // Arrange
            int idHoaDon = 1;
            var hoaDon = new HOADON { SoHoaDon = idHoaDon, TrangThai = "Chưa thanh toán" };

            dbContextMock.Setup(m => m.HOADONs.Find(idHoaDon)).Returns(hoaDon);

            // Act
            dalHoaDon.CapNhatThanhToan(idHoaDon);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
            Assert.AreEqual("Đã thanh toán", hoaDon.TrangThai);
        }
    }
}
