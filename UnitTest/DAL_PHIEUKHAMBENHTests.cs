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
    public class DAL_PHIEUKHAMBENHTests
    {
        private Mock<QLPMTEntities> mockDbContext;
        private DAL_PHIEUKHAMBENH dalPhieuKhamBenh;
        private Mock<IDAL_CTPHIEUKHAMBENH> mockDalCTPhieuKhamBenh;
        private Mock<IDAL_BENHNHAN> mockDalBenhNhan;
        private Mock<IDAL_BENH> mockDalBenh;
        [TestInitialize]
        public void TestInitialize()
        {
            mockDbContext = new Mock<QLPMTEntities>();
            mockDalCTPhieuKhamBenh = new Mock<IDAL_CTPHIEUKHAMBENH>();
            mockDalBenhNhan = new Mock<IDAL_BENHNHAN>();
            mockDalBenh = new Mock<IDAL_BENH>();
            dalPhieuKhamBenh = new DAL_PHIEUKHAMBENH(mockDbContext.Object, mockDalCTPhieuKhamBenh.Object, mockDalBenhNhan.Object, mockDalBenh.Object);
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
        public void ThemPhieuKhamBenh_AddsPhieuKhamBenhToDatabase()
        {
            // Arrange
            PHIEUKHAMBENH phieu = new PHIEUKHAMBENH()
            {
                SoPhieuKhamBenh = 1,
                NgayKham = DateTime.Now,
                idMaBenhNhan = 123,
                MaBenh = 456,
                TrieuChung = "Đau đầu, mệt mỏi",
                TongTien = 100000,
                TrangThai = 1
            };
            mockDbContext.Setup(d => d.PHIEUKHAMBENHs.Add(phieu));
            // Act
            dalPhieuKhamBenh.ThemPhieuKhamBenh(phieu);

            // Assert
            mockDbContext.Verify(d => d.PHIEUKHAMBENHs.Add(phieu), Times.Once());
            mockDbContext.Verify(dbContext => dbContext.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void LayPhieuKhamBenh_ByIdMa_Existing_ReturnPhieuKhamBenh()
        {
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = DateTime.Now, idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };

            mockDbContext.Setup(d => d.PHIEUKHAMBENHs.Find(1)).Returns(phieu1);

            var result = dalPhieuKhamBenh.LayPhieuKhamBenh(1);

            Assert.AreEqual(phieu1, result);
        }
        [TestMethod]
        public void LayPhieuKhamBenh_ByIdMa_NotExisting_ReturnNull()
        {
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = DateTime.Now, idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };

            mockDbContext.Setup(d => d.PHIEUKHAMBENHs.Find(1)).Returns((PHIEUKHAMBENH)null);

            var result = dalPhieuKhamBenh.LayPhieuKhamBenh(1);

            Assert.AreEqual(null, result);
        }
        [TestMethod]
        public void ListTheoNgay_ReturnsListOfPhieuKhamBenhForGivenDate()
        {

            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2023, 11, 12), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2023, 10, 10), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            var listdata = new List<PHIEUKHAMBENH> { phieu1, phieu2 };
            var expectedList = new List<dynamic> { phieu2 };
            int nam = 2023;
            int thang = 10;
            int ngay = 10;
            mockDbContext.Setup(d => d.PHIEUKHAMBENHs).Returns(MockDbSet(listdata));
            // Act
            var result = dalPhieuKhamBenh.ListTheoNgay(ngay, thang, nam);
            // Assert
            Assert.AreEqual(result.Count, expectedList.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].SoPhieuKhamBenh, expectedList[i].SoPhieuKhamBenh);
            }
        }
        [TestMethod]
        public void LuuPhieuKhamBenh_UpdatesPhieuKhamBenhStatusAndSavesChanges()
        {
            // Arrange
            int soPhieuKhamBenh = 1;
            PHIEUKHAMBENH mockPhieuKB = new PHIEUKHAMBENH { SoPhieuKhamBenh = soPhieuKhamBenh, NgayKham = new DateTime(2023, 11, 12), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 0 };
            mockDbContext.Setup(dbSet => dbSet.PHIEUKHAMBENHs.Find(soPhieuKhamBenh)).Returns(mockPhieuKB);

            // Act
            dalPhieuKhamBenh.LuuPhieuKhamBenh(mockPhieuKB);

            // Assert
            Assert.AreEqual(1, mockPhieuKB.TrangThai);
            mockDbContext.Verify(dbContext => dbContext.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void TinhTongTien_CalculatesAndSavesTongTienToPhieuKhamBenh()
        {
            // Arrange
            int soPhieuKhamBenh = 1;
            CT_PHIEUKHAMBENH chiTietPKB1 = new CT_PHIEUKHAMBENH
            {
                SoPhieuKhamBenh = 1,
                idMaThuoc = 1,
                idMaCachDung = 2,
                DonGia = 10000,
                SoLuong = 3,
                ThanhTien = 30000
            };
            CT_PHIEUKHAMBENH chiTietPKB2 = new CT_PHIEUKHAMBENH
            {
                SoPhieuKhamBenh = 1,
                idMaThuoc = 3,
                idMaCachDung = 2,
                DonGia = 10000,
                SoLuong = 3,
                ThanhTien = 30000
            };
            List<CT_PHIEUKHAMBENH> danhSachThuoc = new List<CT_PHIEUKHAMBENH>
            {
                chiTietPKB1,chiTietPKB2
            };
            mockDalCTPhieuKhamBenh.Setup(dal => dal.LayDanhSachThuoc(soPhieuKhamBenh)).Returns(danhSachThuoc);
            PHIEUKHAMBENH mockPhieuKB = new PHIEUKHAMBENH { SoPhieuKhamBenh = soPhieuKhamBenh, NgayKham = new DateTime(2023, 11, 12), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 0 };
            mockDbContext.Setup(d => d.PHIEUKHAMBENHs.Find(soPhieuKhamBenh)).Returns(mockPhieuKB);
            // Act
            dalPhieuKhamBenh.TinhTongTien(soPhieuKhamBenh);
            // Assert
            mockDbContext.Verify(d => d.SaveChanges(), Times.Once);

        }
        [TestMethod]
        public void LayDanhSachPhieuKhamBenh_KieuLocAll_ReturnListPhieuKhamBenh()
        {
            // Arrange
            string kieuLoc = "Tất cả";
            string giaTri = "";
            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2023, 11, 12), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2023, 10, 10), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            var listdata = new List<PHIEUKHAMBENH> { phieu1, phieu2 };
            mockDbContext.Setup(d => d.PHIEUKHAMBENHs).Returns(MockDbSet(listdata));

            // Act
            var result = dalPhieuKhamBenh.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, startDate, endDate);
            // Assert
            Assert.AreEqual(result.Count, listdata.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].SoPhieuKhamBenh, listdata[i].SoPhieuKhamBenh);
            }
        }
        [TestMethod]
        public void LayDanhSachPhieuKhamBenh_KieuLocNgayKham_ReturnListPhieuKhamBenh()
        {
            // Arrange
            string kieuLoc = "Ngày khám";
            string giaTri = "";
            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2021, 10, 10), idMaBenhNhan = 123, MaBenh = 456, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            var listdata = new List<PHIEUKHAMBENH> { phieu1, phieu2 };
            var expantedList = new List<dynamic> { phieu1 };
            mockDbContext.Setup(d => d.PHIEUKHAMBENHs).Returns(MockDbSet(listdata));

            // Act
            var result = dalPhieuKhamBenh.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, startDate, endDate);
            // Assert
            Assert.AreEqual(result.Count, expantedList.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].SoPhieuKhamBenh, listdata[i].SoPhieuKhamBenh);
            }
        }
        [TestMethod]
        public void LayDanhSachPhieuKhamBenh_KieuLocTenBenh_ReturnListPhieuKhamBenh()
        {
            // Arrange
            string kieuLoc = "Tên bệnh";
            string giaTri = "Bệnh một";
            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 123, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2021, 10, 10), idMaBenhNhan = 123, MaBenh = 2, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            var listdata = new List<PHIEUKHAMBENH> { phieu1, phieu2 };

            var expanted = new List<dynamic> { phieu1 };


            var benh = new List<BENH> { new BENH { id = 1, MaBenh = "B1", TenBenh = "Bệnh một", TrieuChung = "Trieu chung 1", idMaLoaiBenh = 1, idMaThuocDacTri = 1 } };

            mockDbContext.Setup(d => d.PHIEUKHAMBENHs).Returns(MockDbSet(listdata));
            mockDalBenh.Setup(d => d.LocBenh(kieuLoc, giaTri)).Returns(benh);

            // Act
            var result = dalPhieuKhamBenh.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, startDate, endDate);
            // Assert
            Assert.AreEqual(result.Count, expanted.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].SoPhieuKhamBenh, listdata[i].SoPhieuKhamBenh);
            }
        }
        [TestMethod]
        public void LayDanhSachPhieuKhamBenh_KieuLocTenBenhNhan_ReturnListPhieuKhamBenh()
        {
            // Arrange
            string kieuLoc = "Tên bệnh nhân";
            string giaTri = "Benh nhan 1";
            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 1, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2021, 10, 10), idMaBenhNhan = 2, MaBenh = 2, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            var listdata = new List<PHIEUKHAMBENH> { phieu1, phieu2 };

            var expanted = new List<dynamic> { phieu1 };


            var benhNhanList = new List<BENHNHAN>
            {
                new BENHNHAN { id = 1, MaBenhNhan = "BN1", HoTenBenhNhan = "Benh Nhan 1", GioiTinh = "Nam", NgaySinh = new DateTime(1990, 1, 1), DiaChi = "Dia chi 1" },
            };

            mockDbContext.Setup(d => d.PHIEUKHAMBENHs).Returns(MockDbSet(listdata));
            mockDalBenhNhan.Setup( d=> d.LocBenhNhan(kieuLoc, giaTri)).Returns(benhNhanList);

            // Act
            var result = dalPhieuKhamBenh.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, startDate, endDate);
            // Assert
            Assert.AreEqual(result.Count, expanted.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].SoPhieuKhamBenh, listdata[i].SoPhieuKhamBenh);
            }
        }
        [TestMethod]
        public void LayDanhSachPhieuKhamBenh_KieuLocMaBenhNhan_ReturnListPhieuKhamBenh()
        {
            // Arrange
            string kieuLoc = "Mã bệnh nhân";
            string giaTri = "BN1";
            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);
            PHIEUKHAMBENH phieu1 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2022, 11, 12), idMaBenhNhan = 1, MaBenh = 1, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            PHIEUKHAMBENH phieu2 = new PHIEUKHAMBENH() { SoPhieuKhamBenh = 1, NgayKham = new DateTime(2021, 10, 10), idMaBenhNhan = 2, MaBenh = 2, TrieuChung = "Đau đầu, mệt mỏi", TongTien = 100000, TrangThai = 1 };
            var listdata = new List<PHIEUKHAMBENH> { phieu1, phieu2 };

            var expanted = new List<dynamic> { phieu1 };


            var benhNhanList = new List<BENHNHAN>
            {
                new BENHNHAN { id = 1, MaBenhNhan = "BN1", HoTenBenhNhan = "Benh Nhan 1", GioiTinh = "Nam", NgaySinh = new DateTime(1990, 1, 1), DiaChi = "Dia chi 1" },
            };

            mockDbContext.Setup(d => d.PHIEUKHAMBENHs).Returns(MockDbSet(listdata));
            mockDalBenhNhan.Setup(d => d.LocBenhNhan(kieuLoc, giaTri)).Returns(benhNhanList);

            // Act
            var result = dalPhieuKhamBenh.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, startDate, endDate);
            // Assert
            Assert.AreEqual(result.Count, expanted.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i].SoPhieuKhamBenh, listdata[i].SoPhieuKhamBenh);
            }
        }

    }
}
