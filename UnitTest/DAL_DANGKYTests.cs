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
        private Mock<DbSet<BENHNHAN>> benhNhanDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            dangKyDbSetMock = new Mock<DbSet<DANGKY>>();
            benhNhanDbSetMock = new Mock<DbSet<BENHNHAN>>();
            dalDangKy = new DAL_DANGKY(dbContextMock.Object);

            // Danh sách đối tượng DANGKY
            var dangKyList = new List<DANGKY>
            {
                new DANGKY { id = 1, MaDangKy = "DK1", idMaBenhNhan = 1, NgayDangKy = new DateTime(2023, 12, 21) },
                new DANGKY { id = 2, MaDangKy = "DK2", idMaBenhNhan = 2, NgayDangKy = new DateTime(2023, 12, 22) },
            // Thêm các đối tượng DANGKY khác vào danh sách nếu cần
            };

            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.Provider).Returns(dangKyList.AsQueryable().Provider);
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.Expression).Returns(dangKyList.AsQueryable().Expression);
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.ElementType).Returns(dangKyList.AsQueryable().ElementType);
            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.GetEnumerator()).Returns(dangKyList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.DANGKies).Returns(dangKyDbSetMock.Object);

            // Danh sách đối tượng BENHNHAN
            var benhNhanList = new List<BENHNHAN>
            {
                new BENHNHAN { id = 1, HoTenBenhNhan = "Bệnh Nhân 1" },
                new BENHNHAN { id = 2, HoTenBenhNhan = "Bệnh Nhân 2" },
            // Thêm các đối tượng BENHNHAN khác vào danh sách nếu cần
            };

            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.Provider).Returns(benhNhanList.AsQueryable().Provider);
            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.Expression).Returns(benhNhanList.AsQueryable().Expression);
            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.ElementType).Returns(benhNhanList.AsQueryable().ElementType);
            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.GetEnumerator()).Returns(benhNhanList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.BENHNHANs).Returns(benhNhanDbSetMock.Object);
        }


        [TestMethod]
        public void XoaDangKy_ShouldRemoveEntry_WhenCalled()
        {
            // Arrange
            DANGKY dangKyToRemove = new DANGKY { id = 1, MaDangKy = "DK1", NgayDangKy = new DateTime(2023, 12, 21), idMaBenhNhan = 1 };

            // Act
            dalDangKy.XoaDangKy(dangKyToRemove);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void XoaDangKy_ShouldNotRemoveEntry_WhenCalledInvalid()
        {
            // Arrange
            DANGKY dangKyToRemove = new DANGKY { id = 3, MaDangKy = "DK3", NgayDangKy = DateTime.Now, idMaBenhNhan = 5 };

            // Act
            dalDangKy.XoaDangKy(dangKyToRemove);

            // Assert
            dbContextMock.Verify(m => m.DANGKies.Remove(dangKyToRemove), Times.Never);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void Test_LayDangKy_WithValidIdBenhNhan()
        {
            // Arrange
            int validIdBenhNhan = 1;

            // Act
            DANGKY result = dalDangKy.LayDangKy(validIdBenhNhan);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(validIdBenhNhan, result.idMaBenhNhan);
        }

        [TestMethod]
        public void Test_LayDangKy_WithInvalidIdBenhNhan()
        {
            // Arrange
            int invalidIdBenhNhan = 999; // Giả sử không có DANGKY nào có idMaBenhNhan là 999

            // Act
            DANGKY result = dalDangKy.LayDangKy(invalidIdBenhNhan);

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void LayDanhSachDangKy_ShouldReturnListOfBenhNhan_WhenCalled()
        {
            // Arrange: Tạo dữ liệu mẫu để hàm có thể lấy danh sách đăng ký
            var dangKyList = new List<DANGKY>
            {
                new DANGKY { idMaBenhNhan = 1, NgayDangKy = new DateTime(2023, 12, 21) },
                new DANGKY { idMaBenhNhan = 2, NgayDangKy = new DateTime(2023, 12, 22) },
            // Thêm các đối tượng DANGKY khác vào danh sách nếu cần
            };

            dangKyDbSetMock.As<IQueryable<DANGKY>>().Setup(m => m.GetEnumerator()).Returns(dangKyList.AsQueryable().GetEnumerator());

            // Act: Gọi hàm cần kiểm thử
            var result = dalDangKy.LayDanhSachDangKy();

            // Assert: Kiểm tra kết quả
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<BENHNHAN>));
            Assert.AreEqual(dangKyList.Count, result.Count);
        }
        [TestMethod]
        public void Test_DangKyKhamBenh_ShouldAddDangKy()
        {
            // Arrange
            var dangKyToAdd = new DANGKY { id = 3, MaDangKy = "DK3", NgayDangKy = DateTime.Now, idMaBenhNhan = 3 };

            // Mock DbContext's Add and SaveChanges methods
            dbContextMock.Setup(m => m.DANGKies.Add(dangKyToAdd));

            // Act
            dalDangKy.DangKyKhamBenh(dangKyToAdd);

            // Assert
            dbContextMock.Verify(m => m.DANGKies.Add(dangKyToAdd), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
