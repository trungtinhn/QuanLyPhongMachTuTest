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
    public class DAL_DANGKYTests
    {
        private DAL_DANGKY dalDangKy;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<DANGKY>> dangKyDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            dangKyDbSetMock = new Mock<DbSet<DANGKY>>();
            dalDangKy = new DAL_DANGKY(dbContextMock.Object);

            // Thiết lập mock cho DbSet
            var dangKyList = new List<DANGKY>();
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.Provider).Returns(dangKyList.AsQueryable().Provider);
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.Expression).Returns(dangKyList.AsQueryable().Expression);
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.ElementType).Returns(dangKyList.AsQueryable().ElementType);
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.GetEnumerator()).Returns(dangKyList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.DANGKies).Returns(dangKyDbSetMock.Object);
        }

        [TestMethod]
        public void XoaDangKy_ShouldRemoveEntry_WhenCalled()
        {
            // Arrange
            DANGKY dangKyToRemove = new DANGKY { id = 1, MaDangKy = "DK1", NgayDangKy = DateTime.Now, idMaBenhNhan = 1 };

            // Act
            dalDangKy.XoaDangKy(dangKyToRemove);

            // Assert
            dbContextMock.Verify(m => m.DANGKies.Remove(dangKyToRemove), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void LayDangKy_ShouldReturnNull_WhenIdBenhNhanNotExists()
        {
            // Arrange
            int idBenhNhanToFind = 999; // Giả sử id không tồn tại

            // Act
            DANGKY foundDangKy = dalDangKy.LayDangKy(idBenhNhanToFind);

            // Assert
            Assert.IsNull(foundDangKy);
        }
    }
}
