using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class DAL_LOAIBENHTests
    {
        private DAL_LOAIBENH dalLoaiBenh;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<IDAL_BENH> idalBenh;
        private Mock<DbSet<LOAIBENH>> dalloaiBenhMock;
        [TestInitialize]
        public void SetUp()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            dalloaiBenhMock = new Mock<DbSet<LOAIBENH>>();
            idalBenh = new Mock<IDAL_BENH>();
            dalLoaiBenh = new DAL_LOAIBENH(dbContextMock.Object, idalBenh.Object);
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
        public void LayDanhSachLoaiBenh_KieuLocAll_ReturnsAllLoaiBenh()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };


            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));


            // Act
            var result = dalLoaiBenh.LayDanhSachLoaiBenh("Tất cả", "");

            // Assert
            Assert.AreEqual(danhSachLoaiBenh.Count, result.Count);
        }
        [TestMethod]
        public void LayDanhSachLoaiBenh_KieuLocMaLoaiBenh_ReturnsListLoaiBenh()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };

            var expected = new List<LOAIBENH> { loaiBenh1 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));


            // Act
            var result = dalLoaiBenh.LayDanhSachLoaiBenh("Mã loại bệnh", "LB001");

            // Assert
            Assert.AreEqual(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].MaLoaiBenh, result[i].MaLoaiBenh);
            }
        }
        [TestMethod]
        public void LayDanhSachLoaiBenh_KieuLocTenLoaiBenh_ReturnsListLoaiBenh()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };

            var expected = new List<LOAIBENH> { loaiBenh1 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));


            // Act
            var result = dalLoaiBenh.LayDanhSachLoaiBenh("Tên loại bệnh", "Loại bệnh 1");

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
            var maBenh = 1;
            var loaiBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };

            dbContextMock.Setup(db => db.LOAIBENHs.Find(maBenh)).Returns(loaiBenh);

            // Act
            var result = dalLoaiBenh.LayTenLoaiBenh(maBenh);

            // Assert
            Assert.AreEqual(loaiBenh.TenLoaiBenh, result);
        }
        [TestMethod]
        public void ThemLoaiBenh_ValidLoaiBenh_UpdatesDatabase()
        {
            // Arrange
            var loaiBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            dbContextMock.Setup(d => d.LOAIBENHs.Add(loaiBenh));
            // Act
            dalLoaiBenh.ThemLoaiBenh(loaiBenh);
            // Assert
            dbContextMock.Verify( d=> d.LOAIBENHs.Add(loaiBenh), Times.Once );
            dbContextMock.Verify(d => d.SaveChanges(), Times.Once());

        }

        [TestMethod]
        public void KiemTra_NotExistingLoaiBenh_ReturnsFalse()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            var expected = new LOAIBENH { id = 3, MaLoaiBenh = "LB003", TenLoaiBenh = "Loại bệnh 3" };
            // Act
            var result = dalLoaiBenh.KiemTraLoaiBenh(expected);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void KiemTra_ExistingLoaiBenh_ReturnsTrue()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            var expected = loaiBenh1;
            // Act
            var result = dalLoaiBenh.KiemTraLoaiBenh(expected);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CapNhatLoaiBenh_ValidLoaiBenh_UpdatesDatabase()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            var expected = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh moi" };
            dbContextMock.Setup(d => d.LOAIBENHs.Find(expected.id)).Returns(expected);

            // Act
            dalLoaiBenh.CapNhatLoaiBenh(expected);

            // Assert
            dbContextMock.Verify(db => db.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void CapNhatLoaiBenh_NotValidLoaiBenh_UpdatesDatabase()
        {
            // Arrange
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            var expected = new LOAIBENH { id = 3, MaLoaiBenh = "LB003", TenLoaiBenh = "Loại bệnh moi" };
            dbContextMock.Setup(d => d.LOAIBENHs.Find(expected.id)).Returns(expected);

            // Act
            dalLoaiBenh.CapNhatLoaiBenh(expected);

            // Assert
            dbContextMock.Verify(db => db.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void XoaLoaiBenh_ValidLoaiBenh_ExistingBenh_UpdatesDatabase()
        {
            // Arrange
            var benh1 = new BENH { id = 3, MaBenh = "LB001", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 1, idMaThuocDacTri = 3 };
            var danhsachbenh = new List<BENH> { benh1 };
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            dbContextMock.Setup(db => db.BENHs).Returns(MockDbSet(danhsachbenh));
            // Act
            dalLoaiBenh.XoaLoaiBenh(loaiBenh1);

            // Assert
            idalBenh.Verify(db => db.XoaBenh(benh1), Times.Once);
            dbContextMock.Verify(db => db.LOAIBENHs.Remove(loaiBenh1), Times.Once);
            dbContextMock.Verify(db => db.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void XoaLoaiBenh_ValidLoaiBenh_NotExistingBenh_UpdatesDatabase()
        {
            // Arrange
            var benh1 = new BENH { id = 3, MaBenh = "LB001", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            var danhsachbenh = new List<BENH> { benh1 };
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            dbContextMock.Setup(db => db.BENHs).Returns(MockDbSet(danhsachbenh));
            // Act
            dalLoaiBenh.XoaLoaiBenh(loaiBenh1);

            // Assert
            idalBenh.Verify(db => db.XoaBenh(benh1), Times.Never);
            dbContextMock.Verify(db => db.LOAIBENHs.Remove(loaiBenh1), Times.Once);
            dbContextMock.Verify(db => db.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void XoaLoaiBenh_NotValidLoaiBenh_UpdatesDatabase()
        {
            // Arrange
            var benh1 = new BENH { id = 3, MaBenh = "LB001", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            var danhsachbenh = new List<BENH> { benh1 };
            var loaiBenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loại bệnh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaiBenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));
            var loaiBenh3 = new LOAIBENH { id = 3, MaLoaiBenh = "LB003", TenLoaiBenh = "Loại bệnh 3" };
            dbContextMock.Setup(db => db.BENHs).Returns(MockDbSet(danhsachbenh));
            // Act
            dalLoaiBenh.XoaLoaiBenh(loaiBenh3);

            // Assert
            idalBenh.Verify(db => db.XoaBenh(benh1), Times.Never);
            dbContextMock.Verify(db => db.LOAIBENHs.Remove(loaiBenh1), Times.Never);
            dbContextMock.Verify(db => db.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void LayThongTinLoaiBenh_ExistingTenLoaiBenh_ReturnsLoaiBenh()
        {
            // Arrange
            var tenLoaiBenh = "Loại bệnh 1";
            var expectedLoaiBenh = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = tenLoaiBenh };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { expectedLoaiBenh, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));


            // Act
            var result = dalLoaiBenh.LayThongTinLoaiBenh(tenLoaiBenh);

            // Assert
            Assert.AreEqual(expectedLoaiBenh, result);
        }
        [TestMethod]
        public void LayThongTinLoaiBenh_NonExistingTenLoaiBenh_ReturnsNull()
        {
            // Arrange
            var tenLoaiBenh = "Loại bệnh không tồn tại";

            var loaibenh1 = new LOAIBENH { id = 1, MaLoaiBenh = "LB001", TenLoaiBenh = "Loai benh 1" };
            var loaiBenh2 = new LOAIBENH { id = 2, MaLoaiBenh = "LB002", TenLoaiBenh = "Loại bệnh 2" };
            var danhSachLoaiBenh = new List<LOAIBENH> { loaibenh1, loaiBenh2 };
            dbContextMock.Setup(m => m.LOAIBENHs).Returns(MockDbSet(danhSachLoaiBenh));

            // Act
            var result = dalLoaiBenh.LayThongTinLoaiBenh(tenLoaiBenh);

            // Assert
            Assert.IsNull(result);
        }
    }
}
