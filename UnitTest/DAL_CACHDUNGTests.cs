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
using System.Linq.Expressions;

namespace UnitTest
{
    [TestClass]
    public class DAL_CACHDUNGTests
    {
        private DAL_CACHDUNG dalCachDung;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<CACHDUNG>> cachDungDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            cachDungDbSetMock = new Mock<DbSet<CACHDUNG>>();
            dalCachDung = new DAL_CACHDUNG(dbContextMock.Object);

            var cachDungList = new List<CACHDUNG>
        {
            new CACHDUNG { id = 1, MaCachDung = "CD1", TenCachDung = "Cach Dung 1" },
            new CACHDUNG { id = 2, MaCachDung = "CD2", TenCachDung = "Cach Dung 2" }
        };

            cachDungDbSetMock.As<IQueryable<CACHDUNG>>().Setup(m => m.Provider).Returns(cachDungList.AsQueryable().Provider);
            cachDungDbSetMock.As<IQueryable<CACHDUNG>>().Setup(m => m.Expression).Returns(cachDungList.AsQueryable().Expression);
            cachDungDbSetMock.As<IQueryable<CACHDUNG>>().Setup(m => m.ElementType).Returns(cachDungList.AsQueryable().ElementType);
            cachDungDbSetMock.As<IQueryable<CACHDUNG>>().Setup(m => m.GetEnumerator()).Returns(cachDungList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.CACHDUNGs).Returns(cachDungDbSetMock.Object);
        }
        [TestMethod]
        public void Test_LayDanhSach()
        {
            // Arrange

            // Act
            var result = dalCachDung.LayDanhSach();

            // Assert
            Assert.IsNotNull(result); // Kiểm tra xem kết quả có tồn tại không
            Assert.IsTrue(result is IEnumerable<CACHDUNG>); // Kiểm tra xem result có phải là một danh sách hay không
            Assert.AreEqual(2, (result as IEnumerable<CACHDUNG>).Count());
        }

        [TestMethod]
        public void KiemTraCachDung_ShouldReturnTrue_WhenCachDungExists()
        {
            // Arrange
            CACHDUNG cachDungToCheck = new CACHDUNG { id = 1, MaCachDung = "CD1", TenCachDung = "Cach Dung 1" };

            // Act
            var result = dalCachDung.KiemTraCachDung(cachDungToCheck);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddCachDung_ShouldAddCachDung_WhenValidCachDungIsProvided()
        {
            // Arrange
            CACHDUNG newCachDung = new CACHDUNG { id = 3, MaCachDung = "CD3", TenCachDung = "Cach Dung 3" };

            // Act
            try
            {
                dalCachDung.AddCachDung(newCachDung);

                // Assert
                dbContextMock.Verify(m => m.CACHDUNGs.Add(It.IsAny<CACHDUNG>()), Times.Once);
                dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
            }
            catch (Exception)
            {
                // If the exception is thrown, the test fails
                Assert.Fail("Exception should not be thrown for a valid CACHDUNG.");
            }
        }
        [TestMethod]
        public void XoaCachDung_ShouldRemoveCachDung_WhenCachDungExists()
        {
            // Arrange
            CACHDUNG existingCachDung = new CACHDUNG { id = 1, MaCachDung = "CD1", TenCachDung = "ExistingCachDung" };
            dbContextMock.Setup(m => m.CACHDUNGs.Find(existingCachDung.id)).Returns(existingCachDung);

            // Act
            dalCachDung.XoaCachDung(existingCachDung);

            // Assert
            dbContextMock.Verify(m => m.CACHDUNGs.Remove(It.IsAny<CACHDUNG>()), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void XoaCachDung_ShouldNotRemoveCachDung_WhenCachDungDoesNotExist()
        {
            // Arrange
            CACHDUNG nonExistingCachDung = new CACHDUNG { id = 2, MaCachDung = "CD2", TenCachDung = "NonExistingCachDung" };
            dbContextMock.Setup(m => m.CACHDUNGs.Find(nonExistingCachDung.id)).Returns((CACHDUNG)null);

            // Act
            dalCachDung.XoaCachDung(nonExistingCachDung);

            // Assert
            dbContextMock.Verify(m => m.CACHDUNGs.Remove(It.IsAny<CACHDUNG>()), Times.Never);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void CapNhatCachDung_ShouldUpdateCachDung_WhenCachDungExists()
        {
            // Arrange
            CACHDUNG cachDungToUpdate = new CACHDUNG { id = 1, MaCachDung = "CD1", TenCachDung = "Cach Dung 1 Updated" };

            // Act
            dalCachDung.CapNhatCachDung(cachDungToUpdate);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
            Assert.AreEqual("Cach Dung 1 Updated", cachDungToUpdate.TenCachDung);
        }
        [TestMethod]
        public void Test_GetAll_ShouldReturnListOfCachDung()
        {
            // Arrange

            // Act
            var result = dalCachDung.getall();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(CACHDUNG));
        }
        [TestMethod]
        public void Test_GetByTen_ShouldReturnCachDung_WhenExists()
        {
            // Arrange
            string tenToSearch = "Cach Dung 1";

            // Act
            var result = dalCachDung.GetByTen(tenToSearch);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(tenToSearch, result.TenCachDung);
        }

        [TestMethod]
        public void Test_GetByTen_ShouldReturnNull_WhenNotExists()
        {
            // Arrange
            string tenToSearch = "Nonexistent Cach Dung";

            // Act
            var result = dalCachDung.GetByTen(tenToSearch);

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Test_GetCDByID_ShouldReturnCachDung_WhenExists()
        {
            // Arrange
            int idToSearch = 1;

            // Act
            var result = dalCachDung.getCDbyID(idToSearch);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(idToSearch, result.id);
        }

        [TestMethod]
        public void Test_GetCDByID_ShouldReturnNull_WhenNotExists()
        {
            // Arrange
            int idToSearch = 3; // Assuming ID 3 does not exist

            // Act
            var result = dalCachDung.getCDbyID(idToSearch);

            // Assert
            Assert.IsNull(result);
        }
    }
}
