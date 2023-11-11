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
    public class DAL_CT_PHIEUNHAPTests
    {
        private DAL_CT_PHIEUNHAP dalCTPhieuNhap;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<CT_PHIEUNHAP>> ctPhieuNhapDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            ctPhieuNhapDbSetMock = new Mock<DbSet<CT_PHIEUNHAP>>();
            dalCTPhieuNhap = new DAL_CT_PHIEUNHAP(dbContextMock.Object);

            var ctPhieuNhapList = new List<CT_PHIEUNHAP>
        {
            new CT_PHIEUNHAP { SoPhieuNhapThuoc = 1, idMaThuoc = 1, DonGiaNhap = 5000, ThanhTien = 10000, SoLuongNhap = 2 },
            new CT_PHIEUNHAP { SoPhieuNhapThuoc = 2, idMaThuoc = 2, DonGiaNhap = 6000, ThanhTien = 12000, SoLuongNhap = 2 }
        };

            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Provider).Returns(ctPhieuNhapList.AsQueryable().Provider);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Expression).Returns(ctPhieuNhapList.AsQueryable().Expression);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.ElementType).Returns(ctPhieuNhapList.AsQueryable().ElementType);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.GetEnumerator()).Returns(ctPhieuNhapList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.CT_PHIEUNHAP).Returns(ctPhieuNhapDbSetMock.Object);
        }

        [TestMethod]
        public void ThemChiTietPhieu_ShouldAddOrUpdateCTPhieu_WhenModelIsValid()
        {
            // Arrange
            CT_PHIEUNHAP modelToAddOrUpdate = new CT_PHIEUNHAP
            {
                SoPhieuNhapThuoc = 3,
                idMaThuoc = 3,
                DonGiaNhap = 7000,
                ThanhTien = 14000,
                SoLuongNhap = 2
            };

            dbContextMock.Setup(m => m.CT_PHIEUNHAP.Add(modelToAddOrUpdate));
            // Act
            dalCTPhieuNhap.ThemChiTietPhieu(modelToAddOrUpdate);

            // Assert
            dbContextMock.Verify(m => m.CT_PHIEUNHAP.Add(modelToAddOrUpdate), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void XoaChiTietPhieu_ShouldRemoveCTPhieu_WhenModelExists()
        {
            // Arrange

            var modelToRemove = new CT_PHIEUNHAP
            { SoPhieuNhapThuoc = 2, idMaThuoc = 2, DonGiaNhap = 6000, ThanhTien = 12000, SoLuongNhap = 2 };

            dbContextMock.Setup(m => m.CT_PHIEUNHAP.Find(modelToRemove.SoPhieuNhapThuoc, modelToRemove.idMaThuoc)).Returns(modelToRemove);
            dbContextMock.Setup(m => m.CT_PHIEUNHAP.Remove(modelToRemove));

            // Act
            bool result = dalCTPhieuNhap.XoaChiTietPhieu(modelToRemove);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void SuaChiTietPhieu_ShouldRemoveCTPhieu_WhenModelExists()
        {
            // Arrange

            var modelToRemove = new CT_PHIEUNHAP
            { SoPhieuNhapThuoc = 2, idMaThuoc = 2, DonGiaNhap = 6000, ThanhTien = 12000, SoLuongNhap = 2 };

            dbContextMock.Setup(m => m.CT_PHIEUNHAP.Find(modelToRemove.SoPhieuNhapThuoc, modelToRemove.idMaThuoc)).Returns(modelToRemove);

            // Act
            dalCTPhieuNhap.SuaChiTietPhieu(modelToRemove);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void XoaAllChiTietPhieu_ShouldRemoveAllCTPhieu_WhenSoPhieuMatches()
        {
            // Arrange
            var ctPhieuNhapList = new List<CT_PHIEUNHAP>
        {
            new CT_PHIEUNHAP { SoPhieuNhapThuoc = 1, idMaThuoc = 1, DonGiaNhap = 5000, ThanhTien = 10000, SoLuongNhap = 2 },
            new CT_PHIEUNHAP { SoPhieuNhapThuoc = 2, idMaThuoc = 2, DonGiaNhap = 6000, ThanhTien = 12000, SoLuongNhap = 2 }
        };

            dbContextMock.Setup(m => m.CT_PHIEUNHAP.Remove(It.IsAny<CT_PHIEUNHAP>())).Callback<CT_PHIEUNHAP>(ct => ctPhieuNhapList.Remove(ct));
            dbContextMock.Setup(m => m.SaveChanges()).Returns(() => ctPhieuNhapList.Count);

            // Act
            bool result = dalCTPhieuNhap.XoaAllChiTietPhieu(2);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

    }
}
