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
    public class DAL_CTPHIEUKHAMBENHTests
    {
        private DAL_CT_PHIEUKHAMBENH dalCTPhieuKhamBenh;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<CT_PHIEUKHAMBENH>> ctPhieuKhamBenhDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            ctPhieuKhamBenhDbSetMock = new Mock<DbSet<CT_PHIEUKHAMBENH>>();
            dalCTPhieuKhamBenh = new DAL_CT_PHIEUKHAMBENH(dbContextMock.Object);

            var ctPhieuKhamBenhList = new List<CT_PHIEUKHAMBENH>
    {
        new CT_PHIEUKHAMBENH { SoPhieuKhamBenh = 1, idMaThuoc = 1, DonGia = 100, ThanhTien = 200, SoLuong = 2 },
        new CT_PHIEUKHAMBENH { SoPhieuKhamBenh = 2, idMaThuoc = 2, DonGia = 150, ThanhTien = 300, SoLuong = 2 }
        // Add more sample data if needed
    };

            ctPhieuKhamBenhDbSetMock.As<IQueryable<CT_PHIEUKHAMBENH>>().Setup(m => m.Provider).Returns(ctPhieuKhamBenhList.AsQueryable().Provider);
            ctPhieuKhamBenhDbSetMock.As<IQueryable<CT_PHIEUKHAMBENH>>().Setup(m => m.Expression).Returns(ctPhieuKhamBenhList.AsQueryable().Expression);
            ctPhieuKhamBenhDbSetMock.As<IQueryable<CT_PHIEUKHAMBENH>>().Setup(m => m.ElementType).Returns(ctPhieuKhamBenhList.AsQueryable().ElementType);
            ctPhieuKhamBenhDbSetMock.As<IQueryable<CT_PHIEUKHAMBENH>>().Setup(m => m.GetEnumerator()).Returns(ctPhieuKhamBenhList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.CT_PHIEUKHAMBENH).Returns(ctPhieuKhamBenhDbSetMock.Object);
        }
        [TestMethod]
        public void Test_ThemCTPKB()
        {
            // Arrange
            var ctPhieuKhamBenh = new CT_PHIEUKHAMBENH
            {
                SoPhieuKhamBenh = 1,
                idMaThuoc = 1,
                DonGia = 100,
                ThanhTien = 200,
                SoLuong = 2
            };

            dbContextMock.Setup(m => m.CT_PHIEUKHAMBENH.Add(ctPhieuKhamBenh));

            // Act
            dalCTPhieuKhamBenh.ThemCTPKB(ctPhieuKhamBenh);

            // Assert
            dbContextMock.Verify(m => m.CT_PHIEUKHAMBENH.Add(ctPhieuKhamBenh), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void SuaCTPKB_ShouldUpdateCTPKB_WhenCTPKBExists()
        {
            // Arrange
            var chiTietPKBToUpdate = new CT_PHIEUKHAMBENH
            {
                SoPhieuKhamBenh = 1,
                idMaThuoc = 1,
                idMaCachDung = 2,
                DonGia = 10000,
                SoLuong = 3,
                ThanhTien = 30000
            };
            dbContextMock.Setup(m => m.CT_PHIEUKHAMBENH.Find(chiTietPKBToUpdate.idMaThuoc, chiTietPKBToUpdate.SoPhieuKhamBenh)).Returns(chiTietPKBToUpdate);

            // Act
            dalCTPhieuKhamBenh.SuaCTPKB(chiTietPKBToUpdate);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void XoaCTPKB_ShouldRemoveCTPKB_WhenCTPKBExists()
        {
            // Arrange
            CT_PHIEUKHAMBENH chiTietPKBToRemove = new CT_PHIEUKHAMBENH
            {
                SoPhieuKhamBenh = 1,
                idMaThuoc = 1,
                idMaCachDung = 2,
                DonGia = 10000,
                SoLuong = 3,
                ThanhTien = 30000
            };

            dbContextMock.Setup(m => m.CT_PHIEUKHAMBENH.Find(chiTietPKBToRemove.SoPhieuKhamBenh, chiTietPKBToRemove.idMaThuoc))
                        .Returns(chiTietPKBToRemove);

            // Act
            dalCTPhieuKhamBenh.XoaCTPKB(chiTietPKBToRemove);

            // Assert
            dbContextMock.Verify(m => m.CT_PHIEUKHAMBENH.Remove(chiTietPKBToRemove), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

    }
}
