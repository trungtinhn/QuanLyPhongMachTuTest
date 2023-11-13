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
        public void Test_GetCTByMa_ShouldReturnCTPhieuNhapList_WhenMaExists()
        {
            // Arrange
            int maToSearch = 1;

            // Act
            var result = dalCTPhieuNhap.GetCTByMa(maToSearch);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count); // Expecting 2 items with ma = 1
        }

        [TestMethod]
        public void Test_GetCTByMa_ShouldReturnEmptyList_WhenMaDoesNotExist()
        {
            // Arrange
            int maToSearch = 3;

            // Act
            var result = dalCTPhieuNhap.GetCTByMa(maToSearch);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count); // Expecting an empty list
        }
        [TestMethod]
        public void Test_ThemChiTietPhieu_ShouldAddNewCTPhieu_WhenCTPhieuDoesNotExist()
        {
            // Arrange
            var modelToAdd = new CT_PHIEUNHAP
            {
                SoPhieuNhapThuoc = 3,
                idMaThuoc = 3,
                DonGiaNhap = 7000,
                ThanhTien = 14000,
                SoLuongNhap = 2
            };

            // Act
            var result = dalCTPhieuNhap.ThemChiTietPhieu(modelToAdd);

            // Assert
            dbContextMock.Verify(m => m.CT_PHIEUNHAP.Add(modelToAdd), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_ThemChiTietPhieu_ShouldUpdateCTPhieu_WhenCTPhieuExists()
        {
            // Arrange
            var modelToUpdate = new CT_PHIEUNHAP
            {
                SoPhieuNhapThuoc = 1,
                idMaThuoc = 1,
                DonGiaNhap = 5500,
                ThanhTien = 11000,
                SoLuongNhap = 3
            };

            // Act
            var result = dalCTPhieuNhap.ThemChiTietPhieu(modelToUpdate);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void Test_GetDataCTPhieuByMaPhieu_WithNullList()
        {
            // Arrange
            int maPhieu = 1;
            List<CT_PHIEUNHAP> ctPhieuList = null; // Assuming a null list for maPhieu

            if (ctPhieuList == null)
            {
                ctPhieuList = new List<CT_PHIEUNHAP>(); // Initialize the list if it's null
            }

            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Provider).Returns(ctPhieuList.AsQueryable().Provider);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Expression).Returns(ctPhieuList.AsQueryable().Expression);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.ElementType).Returns(ctPhieuList.AsQueryable().ElementType);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.GetEnumerator()).Returns(ctPhieuList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.CT_PHIEUNHAP).Returns(ctPhieuNhapDbSetMock.Object);

            // Act
            var result = dalCTPhieuNhap.GetDataCTPhieuByMaPhieu(maPhieu);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Test_GetDataCTPhieuByMaPhieu_WithInvalidMaPhieu()
        {
            // Arrange
            int maPhieu = 999; // Assuming an invalid maPhieu
            var ctPhieuList = new List<CT_PHIEUNHAP>(); // Empty list for an invalid maPhieu

            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Provider).Returns(ctPhieuList.AsQueryable().Provider);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Expression).Returns(ctPhieuList.AsQueryable().Expression);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.ElementType).Returns(ctPhieuList.AsQueryable().ElementType);
            ctPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.GetEnumerator()).Returns(ctPhieuList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.CT_PHIEUNHAP).Returns(ctPhieuNhapDbSetMock.Object);

            // Act
            var result = dalCTPhieuNhap.GetDataCTPhieuByMaPhieu(maPhieu);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(ctPhieuList.Count, result.Count);
        }
        [TestMethod]
        public void XoaChiTietPhieu_ShouldReturnTrue_WhenCTPhieuExistsAndSuccessfullyDeleted()
        {
            // Arrange
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
            var ctPhieuToDelete = new CT_PHIEUNHAP { SoPhieuNhapThuoc = 1, idMaThuoc = 1 };

            // Thiết lập DbSet để trả về đối tượng giả mạo khi được yêu cầu
            ctPhieuNhapDbSetMock.Setup(m => m.Remove(It.IsAny<CT_PHIEUNHAP>())).Callback<CT_PHIEUNHAP>((entity) => ctPhieuNhapList.Remove(entity));

            // Act
            var result = dalCTPhieuNhap.XoaChiTietPhieu(ctPhieuToDelete);

            // Assert
            Assert.AreEqual(1, ctPhieuNhapList.Count); // Đảm bảo rằng một chi tiết phiếu nhập đã được xóa khỏi danh sách giả mạo
        }

        [TestMethod]
        public void XoaChiTietPhieu_ShouldReturnFalse_WhenCTPhieuDoesNotExist()
        {
            // Arrange
            var ctPhieuToDelete = new CT_PHIEUNHAP { SoPhieuNhapThuoc = 3, idMaThuoc = 3 }; // Giả sử chi tiết phiếu này không tồn tại

            // Act
            var result = dalCTPhieuNhap.XoaChiTietPhieu(ctPhieuToDelete);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void SuaChiTietPhieu_ShouldReturnTrue_WhenCTPhieuExistsAndSuccessfullyUpdated()
        {
            // Arrange
            var ctPhieuNhapList = new List<CT_PHIEUNHAP>
            {
            new CT_PHIEUNHAP { SoPhieuNhapThuoc = 1, idMaThuoc = 1, DonGiaNhap = 5000, ThanhTien = 10000, SoLuongNhap = 2 }
            };
            var ctPhieuToUpdate = new CT_PHIEUNHAP { SoPhieuNhapThuoc = 1, idMaThuoc = 1,  DonGiaNhap = 5500, ThanhTien = 16500, SoLuongNhap = 3};

            // Act
            dalCTPhieuNhap.SuaChiTietPhieu(ctPhieuToUpdate);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void SuaChiTietPhieu_ShouldReturnFalse_WhenCTPhieuDoesNotExist()
        {
            // Arrange
            var ctPhieuToUpdate = new CT_PHIEUNHAP { SoPhieuNhapThuoc = 3, idMaThuoc = 3 }; // Giả sử chi tiết phiếu này không tồn tại

            // Act
            var result = dalCTPhieuNhap.SuaChiTietPhieu(ctPhieuToUpdate);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Test_XoaAllChiTietPhieu_WithValidSoPhieu()
        {
            // Arrange
            int soPhieuToDelete = 1;

            // Act
            bool result = dalCTPhieuNhap.XoaAllChiTietPhieu(soPhieuToDelete);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_XoaAllChiTietPhieu_WithInvalidSoPhieu()
        {
            // Arrange
            int soPhieuToDelete = 4;

            // Act
            bool result = dalCTPhieuNhap.XoaAllChiTietPhieu(soPhieuToDelete);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Test_Getall_WithValidSoPhieu()
        {
            // Arrange
            int validSoPhieu = 1;

            // Act
            var result = dalCTPhieuNhap.Getall(validSoPhieu);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void Test_Getall_WithInvalidSoPhieu()
        {
            // Arrange
            int invalidSoPhieu = 4;

            // Act
            var result = dalCTPhieuNhap.Getall(invalidSoPhieu);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}
