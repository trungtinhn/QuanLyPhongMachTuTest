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
    public class DAL_DONVITests
    {
        private DAL_DONVI dalDonVi;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<DONVI>> donViDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            donViDbSetMock = new Mock<DbSet<DONVI>>();
            dalDonVi = new DAL_DONVI(dbContextMock.Object);

            var donViList = new List<DONVI>
        {
            new DONVI { id = 1, MaDonvi = "DV1", TenDonVi = "Don Vi 1" },
            new DONVI { id = 2, MaDonvi = "DV2", TenDonVi = "Don Vi 2" }
        };

            donViDbSetMock.As<IQueryable<DONVI>>().Setup(m => m.Provider).Returns(donViList.AsQueryable().Provider);
            donViDbSetMock.As<IQueryable<DONVI>>().Setup(m => m.Expression).Returns(donViList.AsQueryable().Expression);
            donViDbSetMock.As<IQueryable<DONVI>>().Setup(m => m.ElementType).Returns(donViList.AsQueryable().ElementType);
            donViDbSetMock.As<IQueryable<DONVI>>().Setup(m => m.GetEnumerator()).Returns(donViList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.DONVIs).Returns(donViDbSetMock.Object);
        }

        [TestMethod]
        public void Add_ShouldAddDonVi_WhenDonViIsValid()
        {
            // Arrange
            DONVI donViToAdd = new DONVI { id = 3, MaDonvi = "DV3", TenDonVi = "Don Vi 3" };

            // Act
            dalDonVi.Add(donViToAdd);

            // Assert
            donViDbSetMock.Verify(m => m.Add(donViToAdd), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void Check_ShouldReturnTrue_WhenTenDonViExists()
        {
            // Arrange
            string existingTenDonVi = "Don Vi 1";

            // Act
            bool result = dalDonVi.Check(existingTenDonVi);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenTenDonViDoesNotExist()
        {
            // Arrange
            string nonExistingTenDonVi = "Non-Existent Don Vi";

            // Act
            bool result = dalDonVi.Check(nonExistingTenDonVi);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Xoa_ShouldRemoveDonVi_WhenDonViExists()
        {
            // Arrange
            DONVI donViToRemove = new DONVI { id = 1, MaDonvi = "DV1", TenDonVi = "Don Vi 1" };

            dbContextMock.Setup(m => m.DONVIs.Find(donViToRemove.id)).Returns(donViToRemove);
            dbContextMock.Setup(m => m.DONVIs.Remove(donViToRemove));

            // Act
            dalDonVi.Xoa(donViToRemove);

            // Assert
            dbContextMock.Verify(m => m.DONVIs.Remove(donViToRemove), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void CapNhat_ShouldUpdateDonVi_WhenDonViExists()
        {
            // Arrange
            DONVI donViToUpdate = new DONVI { id = 1, MaDonvi = "DV1", TenDonVi = "Don Vi 1 Updated" };

            dbContextMock.Setup(m => m.DONVIs.Find(donViToUpdate.id)).Returns(donViToUpdate);

            // Act
            dalDonVi.CapNhat(donViToUpdate);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

    }
}
