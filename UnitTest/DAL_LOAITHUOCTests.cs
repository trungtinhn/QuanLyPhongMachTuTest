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
    public class DAL_LOAITHUOCTests
    {
        private Mock<QLPMTEntities> mockDb;
        private DAL_LOAITHUOC dAL_LOAITHUOC;
        [TestInitialize]
        public void SetUp()
        {
            mockDb = new Mock<QLPMTEntities>();
            dAL_LOAITHUOC = new DAL_LOAITHUOC(mockDb.Object);
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
        public void LayDanhSachLoaiThuoc_ReturnsData()
        {
            //
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));
            var result = dAL_LOAITHUOC.LayDanhSachLoaiThuoc();
            //
            Assert.IsNotNull(result);


        }
        [TestMethod]
        public void LayLoaiThuoc_ValidMaLoaiThuoc_ReturnsLoaiThuoc()
        {
            // Arrange
            string maloaithuoc = "LT1";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));

            // Act
            var result = dAL_LOAITHUOC.LayLoaiThuoc(maloaithuoc);

            // Assert
            Assert.AreEqual(loaithuoc1, result);
        }
        [TestMethod]
        public void LayTenLoaiThuoc_ValidIdLoaiThuoc_ReturnsTenLoaiThuoc()
        {
            // Arrange
            int id = 1;
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));
            mockDb.Setup(db => db.LOAITHUOCs.Find(id)).Returns(loaithuoc1);
            // Act
            var result = dAL_LOAITHUOC.LayTenLoaiThuoc(id);

            // Assert
            Assert.AreEqual(loaithuoc1.TenLoaiThuoc, result);
        }
        [TestMethod]
        public void KiemTra_ExistingLOAITHUOC_ReturnsTrue()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));
            // Act
            var result = dAL_LOAITHUOC.KiemTra(loaithuoc1);

            // Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void KiemTra_NonExistingLOAITHUOC_ReturnsFalse()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };
            var newloaithuoc = new LOAITHUOC { id = 3, MaLoaiThuoc = "LT3", TenLoaiThuoc = "Loại thuốc 3" };
            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));
            // Act
            var result = dAL_LOAITHUOC.KiemTra(newloaithuoc);

            // Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void ThemLoaiThuoc_ValidLoaiThuoc_UpdatesDatabase()
        {
            // Arrange
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            mockDb.Setup(d => d.LOAITHUOCs.Add(loaiThuoc));
            // Act
            dAL_LOAITHUOC.Add(loaiThuoc);

            // Assert
            mockDb.Verify(d => d.LOAITHUOCs.Add(loaiThuoc), Times.Once);
            mockDb.Verify(d => d.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void Check_ExistingTenLoaiThuoc_ReturnsTrue()
        {
            // Arrange
            string TenLoaiThuoc = "Loại thuốc 1";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));

            // Act
            var result = dAL_LOAITHUOC.Check(TenLoaiThuoc);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_NonExistingTenLoaiThuoc_ReturnsFalse()
        {
            // Arrange
            string TenLoaiThuoc = "Loại thuốc 3";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));

            // Act
            var result = dAL_LOAITHUOC.Check(TenLoaiThuoc);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CapNhat_ExistingLOAITHUOC_ReturnTrueUpdatesDatabase()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));


            var loaithuocnew = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc moi" };
            mockDb.Setup(d => d.LOAITHUOCs.Find(loaithuocnew.id)).Returns(loaithuocnew);


            // Act
            var result = dAL_LOAITHUOC.CapNhat(loaithuocnew);

            // Assert
            Assert.IsTrue(result);
            mockDb.Verify(d => d.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void CapNhat_NotExistingLOAITHUOC_ReturnFalse()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));


            var loaithuocnew = new LOAITHUOC { id = 3, MaLoaiThuoc = "LT3", TenLoaiThuoc = "Loại thuốc 3" };
            mockDb.Setup(d => d.LOAITHUOCs.Find(loaithuocnew.id)).Returns((LOAITHUOC)null);


            // Act
            var result = dAL_LOAITHUOC.CapNhat(loaithuocnew);

            // Assert
            Assert.IsFalse(result);
            mockDb.Verify(d => d.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void GetData_ReturnsListOfLOAITHUOC()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));
            // Act
            var result = dAL_LOAITHUOC.GetData();

            // Assert
            Assert.AreEqual(danhsachLoaiThuoc.Count, result.Count);
        }
        [TestMethod]
        public void GetDataByMa_ValidIdLoaiThuoc_ReturnsLOAITHUOC()
        {
            // Arrange
            int id = 1;
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));
            mockDb.Setup(d => d.LOAITHUOCs.Find(id)).Returns(loaithuoc1);

            // Act
            var result = dAL_LOAITHUOC.GetDataByMa(id);

            // Assert
            Assert.AreEqual(loaithuoc1, result);
        }
        [TestMethod]
        public void Xoa_ExistingLOAITHUOC_RemovesFromDatabase()
        {
            // Arrange
            var existingLOAITHUOC = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            mockDb.Setup(d => d.LOAITHUOCs.Find(existingLOAITHUOC.id)).Returns(existingLOAITHUOC);

            // Act
            dAL_LOAITHUOC.Xoa(existingLOAITHUOC);

            // Assert
            mockDb.Verify(d => d.LOAITHUOCs.Remove(existingLOAITHUOC), Times.Once);
            mockDb.Verify(d => d.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void Xoa_NonExistingLOAITHUOC_DoesNotRemoveFromDatabase()
        {
            // Arrange
            var nonExistingLOAITHUOC = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            mockDb.Setup(d => d.LOAITHUOCs.Find(nonExistingLOAITHUOC.id)).Returns((LOAITHUOC)null);

            // Act
            dAL_LOAITHUOC.Xoa(nonExistingLOAITHUOC);

            // Assert
            mockDb.Verify(d => d.LOAITHUOCs.Remove(nonExistingLOAITHUOC), Times.Never);
            mockDb.Verify(d => d.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void LayThongTinLoaiThuoc_ExistingTenLoaiThuoc_ReturnsLoaiThuoc()
        {
            // Arrange
            string TenLoaiThuoc = "Loại thuốc 1";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));

            // Act
            var result = dAL_LOAITHUOC.GetDataByten(TenLoaiThuoc);

            // Assert
            Assert.AreEqual(loaithuoc1, result);
        }
        [TestMethod]
        public void LayThongTinLoaiThuoc_NotExistingTenLoaiThuoc_ReturnsNull()
        {
            // Arrange
            string TenLoaiThuoc = "Loại thuốc 3";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC {id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockDb.Setup(d => d.LOAITHUOCs).Returns(MockDbSet(danhsachLoaiThuoc));

            // Act
            var result = dAL_LOAITHUOC.GetDataByten(TenLoaiThuoc);

            // Assert
            Assert.AreEqual(null, result);
        }
    }
}
