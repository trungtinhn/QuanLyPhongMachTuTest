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
        private Mock<IDAL_PHIEUKHAMBENH> idalpkb;
        private Mock<IDAL_THAMSO> hoaTHAMSODbSet;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            hoaDonDbSetMock = new Mock<DbSet<HOADON>>();
            idalpkb = new Mock<IDAL_PHIEUKHAMBENH>();
            hoaTHAMSODbSet = new Mock<IDAL_THAMSO>();
            dalHoaDon = new DAL_HOADON(dbContextMock.Object, hoaTHAMSODbSet.Object, idalpkb.Object);
            
        }
        private static DbSet<T> MockDbSet<T>(List<T> data) where T : class
        {
            var queryableData = data.AsQueryable();
            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryableData.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryableData.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryableData.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryableData.GetEnumerator());
            return mockSet.Object;
        }

        [TestMethod]
        public void LayDanhSachHoaDon_ShouldReturnListOfHoaDon_WhenIdBenhNhanIsValid()
        {
            // Arrange
            var hoaDonList = new List<HOADON>
            {
                new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" },
                new HOADON { SoHoaDon = 2, SoPhieuKhamBenh = 2, TienKham = 25000, TienThuoc = 60000, idBenhNhan = 1, TrangThai = "ChuaThanhToan" },
                //Thêm dữ liệu mẫu tương ứng với idBenhNhan khác nếu cần
            };
            dbContextMock.Setup(m => m.HOADONs).Returns(MockDbSet(hoaDonList));
              
            int idBenhNhan = 1;

            // Act
            var result = dalHoaDon.LayDanhSachHoaDon(idBenhNhan);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<HOADON>));
            Assert.AreEqual(2, result.Count); // Số lượng hoa đơn tương ứng với idBenhNhan trong dữ liệu mẫu.
        }
        [TestMethod]
        public void TaoHoaDon_ValidHoaDon_SavesChangesToDatabase()
        {
            // Arrange
            var hoaDon = new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" };
            THAMSO expectedThamSo = new THAMSO { id = 1, TienKham = 20000, SoBenhNhanToiDa = 50, SoLuongSapHet = 5 };
            hoaTHAMSODbSet.Setup(dal => dal.LayThamSo(1)).Returns(expectedThamSo);
            dbContextMock.Setup(d => d.HOADONs.Add(hoaDon));
            // Act
            dalHoaDon.TaoHoaDon(hoaDon);

            // Assert
            dbContextMock.Verify(db => db.HOADONs.Add(hoaDon), Times.Once);
            dbContextMock.Verify(db => db.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void LayHoaDon_ShouldReturnHoaDon_WhenSoPhieuKhamBenhIsValid()
        {
            // Arrange
            var hoadon1 = new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" };
            var hoaDonList = new List<HOADON>
            {
                new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" },
                new HOADON { SoHoaDon = 2, SoPhieuKhamBenh = 2, TienKham = 25000, TienThuoc = 60000, idBenhNhan = 1, TrangThai = "ChuaThanhToan" },
                //Thêm dữ liệu mẫu tương ứng với idBenhNhan khác nếu cần
            };
            dbContextMock.Setup(m => m.HOADONs).Returns(MockDbSet(hoaDonList));

            int soPhieuKhamBenh = 1;

            // Act
            var result = dalHoaDon.LayHoaDon(soPhieuKhamBenh);

            // Assert
            Assert.AreEqual(hoadon1.SoHoaDon, result.SoHoaDon);
        }
        [TestMethod]
        public void LayHoaDon_ShouldReturnNul_WhenSoPhieuKhamBenhIsNotValid()
        {
            // Arrange
            var hoaDonList = new List<HOADON>
            {
                new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" },
                new HOADON { SoHoaDon = 2, SoPhieuKhamBenh = 2, TienKham = 25000, TienThuoc = 60000, idBenhNhan = 1, TrangThai = "ChuaThanhToan" },
                //Thêm dữ liệu mẫu tương ứng với idBenhNhan khác nếu cần
            };
            dbContextMock.Setup(m => m.HOADONs).Returns(MockDbSet(hoaDonList));

            int soPhieuKhamBenh = 3;

            // Act
            var result = dalHoaDon.LayHoaDon(soPhieuKhamBenh);

            // Assert
            Assert.IsNull(result);
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
        [TestMethod]
        public void TongDoanhThuNgay_ValidDate_ReturnsCorrectTotalRevenue()
        {
            // Arrange
            var hoaDons = new List<HOADON>
            {
               new HOADON { SoHoaDon = 1, SoPhieuKhamBenh = 1, TienKham = 20000, TienThuoc = 50000, idBenhNhan = 1, TrangThai = "HoanTat" },
                new HOADON { SoHoaDon = 2, SoPhieuKhamBenh = 1, TienKham = 25000, TienThuoc = 60000, idBenhNhan = 1, TrangThai = "ChuaThanhToan" },
            };
            dbContextMock.Setup(db => db.HOADONs).Returns(MockDbSet(hoaDons));
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 1, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2021, 10, 10), idMaBenhNhan = 2, MaBenh = 2, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            idalpkb.Setup(dal => dal.LayPhieuKhamBenh(1)).Returns(phieu2);

            // Act
            int result = dalHoaDon.TongDoanhThuNgay(10, 10, 2021);

            // Assert
            Assert.AreEqual(155000, result);
        }
        [TestMethod]
        public void TongDoanhThuNgay_NoMatchingDate_ReturnsZero()
        {
            // Arrange
            var hoaDons = new List<HOADON>
            {
                new HOADON { SoPhieuKhamBenh = 1, TienKham = 100, TienThuoc = 50 },
                new HOADON { SoPhieuKhamBenh = 2, TienKham = 200, TienThuoc = 100 },
                new HOADON { SoPhieuKhamBenh = 3, TienKham = 150, TienThuoc = 75 }
            };
            dbContextMock.Setup(db => db.HOADONs).Returns(MockDbSet(hoaDons));
            var pkb1 = new PHIEUKHAMBENH { NgayKham = new DateTime(2023, 11, 13) };
            var pkb2 = new PHIEUKHAMBENH { NgayKham = new DateTime(2023, 11, 14) };
            var pkb3 = new PHIEUKHAMBENH { NgayKham = new DateTime(2023, 11, 13) };
            idalpkb.Setup(dal => dal.LayPhieuKhamBenh(1)).Returns(pkb1);
            idalpkb.Setup(dal => dal.LayPhieuKhamBenh(2)).Returns(pkb2);
            idalpkb.Setup(dal => dal.LayPhieuKhamBenh(3)).Returns(pkb3);

            // Act
            int result = dalHoaDon.TongDoanhThuNgay(15, 11, 2023);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
