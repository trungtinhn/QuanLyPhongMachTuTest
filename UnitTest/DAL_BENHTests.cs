using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using DTO;

namespace UnitTest
{
    [TestClass]
    public class DAL_BENHTests
    {
        private DAL_BENH dalBenh;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<BENH>> benhDbSetMock;
        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            benhDbSetMock = new Mock<DbSet<BENH>>();
            dalBenh = new DAL_BENH(dbContextMock.Object);
            var benhList = new List<BENH> {
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 }
            };
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Provider).Returns(benhList.AsQueryable().Provider);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Expression).Returns(benhList.AsQueryable().Expression);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.ElementType).Returns(benhList.AsQueryable().ElementType);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.GetEnumerator()).Returns(benhList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.BENHs).Returns(benhDbSetMock.Object);
        }
        [TestMethod]
        public void Test_LayThongTinBenh()
        {
            // Arrange
     
            // Act
            var result = dalBenh.LayThongTinBenh();

            // Assert
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void Test_ThemBenh()
        {
            // Arrange
            var benh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };

            dbContextMock.Setup(m => m.BENHs.Add(benh));
            // Act
            dalBenh.ThemBenh(benh);

            // Assert
            dbContextMock.Verify(m => m.BENHs.Add(benh), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_CapNhatBenh()
        {
            // Arrange
            var benh = new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh mot", TrieuChung = "Trieu chung 1", idMaLoaiBenh = 1, idMaThuocDacTri = 1 };

            dbContextMock.Setup(m => m.BENHs.Find(benh.id)).Returns(benh);

            // Act
            dalBenh.CapNhatBenh(benh);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_XoaBenh()
        {
            // Arrange
            var benh = new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2", idMaLoaiBenh = 2, idMaThuocDacTri = 2 };

            dbContextMock.Setup(m => m.BENHs.Find(benh.id)).Returns(benh);
            dbContextMock.Setup(m => m.BENHs.Remove(benh));
            // Act
            dalBenh.XoaBenh(benh);
            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void Test_KiemTraBenh_ExistingBenh()
        {
            // Arrange
            var existingBenh = new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2", idMaLoaiBenh = 2, idMaThuocDacTri = 2 };

            dbContextMock.Setup(m => m.BENHs.Find(existingBenh.id)).Returns(existingBenh);

            // Act
            var result = dalBenh.KiemTraBenh(existingBenh);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_KiemTraBenh_NotExistingBenh()
        {
            // Arrange
            var notexistingBenh = new BENH { id = 4, MaBenh = "B4", TenBenh = "Benh 4", TrieuChung = "Trieu chung 4", idMaLoaiBenh = 4, idMaThuocDacTri = 4 };
            dbContextMock.Setup(m => m.BENHs.Find(notexistingBenh.id)).Returns(notexistingBenh);

            // Act
            var result = dalBenh.KiemTraBenh(notexistingBenh);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Test_LayBenh_ByIdBenh_Existing()
        {
            // Arrange
            var idBenh = 1;
            var expectedBenh = new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 };
            dbContextMock.Setup(db => db.BENHs.Find(idBenh)).Returns(expectedBenh);
            // Act
            var result = dalBenh.LayBenh(idBenh);

            // Assert
            Assert.AreEqual(expectedBenh.id, result.id);
        }
        [TestMethod]
        public void Test_LayBenh_ByIdBenh_NotExisting()
        {
            //Arrange
            var idBenh = 3;
            var expectedBenh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dbContextMock.Setup(db => db.BENHs.Find(idBenh)).Returns((BENH)null);
            //Act
            var result = dalBenh.LayBenh(idBenh);

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Test_LayBenh_ByMaBenh_Existing()
        {
            // Arrange
            var maBenh = "B1";
            var expectedBenh = new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1", idMaLoaiBenh = 1, idMaThuocDacTri = 1 };
            dbContextMock.Setup(db => db.BENHs.Find(maBenh)).Returns(expectedBenh);
            // Act
            var result = dalBenh.LayBenh(maBenh);

            // Assert
            Assert.AreEqual(expectedBenh.id, result.id);
        }
        [TestMethod]
        public void Test_LayBenh_ByMaBenh_NotExisting()
        {
            // Arrange
            var maBenh = "B3";
            var expectedBenh = new BENH { id = 3, MaBenh = "B3", TenBenh = "Benh 3", TrieuChung = "Trieu chung 3", idMaLoaiBenh = 3, idMaThuocDacTri = 3 };
            dbContextMock.Setup(db => db.BENHs.Find(maBenh)).Returns((BENH)null);
            // Act
            var result = dalBenh.LayBenh(maBenh);

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Test_LocBenh_TatCa()
        {
            // Arrange
            var benhList = new List<BENH>
            {
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 }
            };

            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Provider).Returns(benhList.AsQueryable().Provider);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Expression).Returns(benhList.AsQueryable().Expression);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.ElementType).Returns(benhList.AsQueryable().ElementType);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.GetEnumerator()).Returns(benhList.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.BENHs).Returns(benhDbSetMock.Object);

            var expectedBenhs = new List<BENH> { 
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 } 
            };
            // Act
            var result = dalBenh.LocBenh("Tất cả", "");

            // Assert
            Assert.AreEqual(expectedBenhs.Count, result.Count);
            for (int i = 0; i < expectedBenhs.Count; i++)
            {
                Assert.AreEqual(expectedBenhs[i].id, result[i].id);
                Assert.AreEqual(expectedBenhs[i].MaBenh, result[i].MaBenh);
                Assert.AreEqual(expectedBenhs[i].TenBenh, result[i].TenBenh);
                Assert.AreEqual(expectedBenhs[i].idMaLoaiBenh, result[i].idMaLoaiBenh);
                Assert.AreEqual(expectedBenhs[i].idMaThuocDacTri, result[i].idMaThuocDacTri);
            }
        }
        [TestMethod]
        public void Test_LocBenh_MaBenh()
        {
            // Arrange
            string maBenhToMatch = "B1";
            var benhList = new List<BENH>
            {
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 }
            };

            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Provider).Returns(benhList.AsQueryable().Provider);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Expression).Returns(benhList.AsQueryable().Expression);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.ElementType).Returns(benhList.AsQueryable().ElementType);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.GetEnumerator()).Returns(benhList.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.BENHs).Returns(benhDbSetMock.Object);
            var expectedBenhs = new List<BENH> { new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1", idMaLoaiBenh = 1, idMaThuocDacTri = 1 } };
            // Act
            var result = dalBenh.LocBenh("Mã bệnh", maBenhToMatch);

            // Assert
            Assert.AreEqual(expectedBenhs.Count, result.Count);
            for (int i = 0; i < expectedBenhs.Count; i++)
            {
                Assert.AreEqual(expectedBenhs[i].id, result[i].id);
                Assert.AreEqual(expectedBenhs[i].MaBenh, result[i].MaBenh);
                Assert.AreEqual(expectedBenhs[i].TenBenh, result[i].TenBenh);
                Assert.AreEqual(expectedBenhs[i].idMaLoaiBenh, result[i].idMaLoaiBenh);
                Assert.AreEqual(expectedBenhs[i].idMaThuocDacTri, result[i].idMaThuocDacTri);
            }
        }
        [TestMethod]
        public void Test_LocBenh_TenBenh()
        {
            // Arrange
            string tenBenhToMatch = "Benh 1";
            var benhList = new List<BENH>
            {
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 }
            };

            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Provider).Returns(benhList.AsQueryable().Provider);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Expression).Returns(benhList.AsQueryable().Expression);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.ElementType).Returns(benhList.AsQueryable().ElementType);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.GetEnumerator()).Returns(benhList.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.BENHs).Returns(benhDbSetMock.Object);
            var expectedBenhs = new List<BENH> { new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1", idMaLoaiBenh = 1, idMaThuocDacTri = 1 } };
            // Act
            var result = dalBenh.LocBenh("Tên bệnh", tenBenhToMatch);

            // Assert
            Assert.AreEqual(expectedBenhs.Count, result.Count);
            for (int i = 0; i < expectedBenhs.Count; i++)
            {
                Assert.AreEqual(expectedBenhs[i].id, result[i].id);
                Assert.AreEqual(expectedBenhs[i].MaBenh, result[i].MaBenh);
                Assert.AreEqual(expectedBenhs[i].TenBenh, result[i].TenBenh);
                Assert.AreEqual(expectedBenhs[i].idMaLoaiBenh, result[i].idMaLoaiBenh);
                Assert.AreEqual(expectedBenhs[i].idMaThuocDacTri, result[i].idMaThuocDacTri);
            }
        }
        [TestMethod]
        public void Test_LocBenh_TrieuChung()
        {
            // Arrange
            string trieuchungToMatch = "Trieu chung 1";
            var benhList = new List<BENH>
            {
                new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1",idMaLoaiBenh = 1, idMaThuocDacTri = 1 },
                new BENH { id = 2, MaBenh = "B2", TenBenh = "Benh 2", TrieuChung = "Trieu chung 2",idMaLoaiBenh = 2, idMaThuocDacTri = 2 }
            };

            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Provider).Returns(benhList.AsQueryable().Provider);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.Expression).Returns(benhList.AsQueryable().Expression);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.ElementType).Returns(benhList.AsQueryable().ElementType);
            benhDbSetMock.As<IQueryable<BENH>>().Setup(m => m.GetEnumerator()).Returns(benhList.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.BENHs).Returns(benhDbSetMock.Object);
            var expectedBenhs = new List<BENH> { new BENH { id = 1, MaBenh = "B1", TenBenh = "Benh 1", TrieuChung = "Trieu chung 1", idMaLoaiBenh = 1, idMaThuocDacTri = 1 } };
            // Act
            var result = dalBenh.LocBenh("Triệu chứng", trieuchungToMatch);

            // Assert
            Assert.AreEqual(expectedBenhs.Count, result.Count);
            for (int i = 0; i < expectedBenhs.Count; i++)
            {
                Assert.AreEqual(expectedBenhs[i].id, result[i].id);
                Assert.AreEqual(expectedBenhs[i].MaBenh, result[i].MaBenh);
                Assert.AreEqual(expectedBenhs[i].TenBenh, result[i].TenBenh);
                Assert.AreEqual(expectedBenhs[i].idMaLoaiBenh, result[i].idMaLoaiBenh);
                Assert.AreEqual(expectedBenhs[i].idMaThuocDacTri, result[i].idMaThuocDacTri);
            }
        }
    }
}
