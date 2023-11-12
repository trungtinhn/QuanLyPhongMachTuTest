using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace UnitTest
{
    [TestClass]
    public class DAL_CTPHIEUNHAPTHUOCTests
    {
        private Mock<QLPMTEntities> mockDbContext;
        private DAL_PHIEUNHAPTHUOC phieuNhapThuocDAL;
        [TestInitialize]
        public void SetUp()
        {
            mockDbContext = new Mock<QLPMTEntities>();
            phieuNhapThuocDAL = new DAL_PHIEUNHAPTHUOC(mockDbContext.Object);
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
        public void GetData_ReturnsListOfPHIEUNHAPTHUOC()
        {
            // Arrange
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12),TrangThai = 1};
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 2, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };
            
            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData)); // Thiết lập mockDbSet cho db.PHIEUNHAPTHUOCs

            // Act
            List<PHIEUNHAPTHUOC> actualData = phieuNhapThuocDAL.GetData();

            // Assert
            Assert.AreEqual(expectedData.Count, actualData.Count);
            // Kiểm tra các phần tử trong danh sách có tương ứng với nhau
            for (int i = 0; i < expectedData.Count; i++)
            {
                Assert.AreEqual(expectedData[i], actualData[i]);
            }
        }
        [TestMethod]
        public void GetDataByMa_Existing_ReturnsPHIEUNHAPTHUOC()
        {
            // Arrange
            int maPhieu = 1;
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 2, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));

            // Act
            PHIEUNHAPTHUOC result = phieuNhapThuocDAL.GetDataByMa(maPhieu);

            // Assert
            Assert.IsNotNull(result); // Kiểm tra kết quả không null
            Assert.AreEqual(phieuNhap1, result); // Kiểm tra mã phiếu nhập thuốc trả về
        }
        [TestMethod]
        public void GetDataByMa_NotExisting_ReturnsNull()
        {
            // Arrange
            int maPhieu = 3;
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 2, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));

            // Act
            PHIEUNHAPTHUOC result = phieuNhapThuocDAL.GetDataByMa(maPhieu);

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void GetMaMax_ReturnsMaxMaPhieu()
        {
            // Arrange
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 7, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 0 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));
            // Act
            int result = phieuNhapThuocDAL.GetMaMax();

            // Assert
            Assert.AreEqual(7, result); // Kiểm tra mã phiếu nhập thuốc lớn nhất
        }
        [TestMethod]
        public void ThemPhieuNhapThuoc_UpdateDatabase()
        {
            // Arrange
            var phieu = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 0 };
            mockDbContext.Setup(d => d.PHIEUNHAPTHUOCs.Add(phieu));
            // Act
            bool result = phieuNhapThuocDAL.ThemPhieu(phieu);

            // Assert
            mockDbContext.Verify(d=> d.SaveChanges(), Times.Once());
            mockDbContext.Verify(db => db.PHIEUNHAPTHUOCs.Add(phieu), Times.Once);

        }
        [TestMethod]
        public void LuuPhieuNhapThuoc_Existing_UpdatesTrangThai_ReturnTrue()
        {
            // Arrange
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 7, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 0 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));
            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs.Find(1)).Returns(phieuNhap1);
            // Act
            var result = phieuNhapThuocDAL.LuuPhieuNhapThuoc(phieuNhap1);

            // Assert
            mockDbContext.Verify(d=>d.SaveChanges(), Times.Once);
            Assert.AreEqual(true, result); // Kiểm tra trạng thái đã được cập nhật thành 1
        }
        [TestMethod]
        public void LuuPhieuNhapThuoc_NotExisting_UpdatesTrangThai_ReturnFalse()
        {
            // Arrange
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 7, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1};

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));
            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs.Find(7)).Returns((PHIEUNHAPTHUOC)null);
            // Act
            var result = phieuNhapThuocDAL.LuuPhieuNhapThuoc(phieuNhap2);

            // Assert
            mockDbContext.Verify(d => d.SaveChanges(), Times.Never);
            Assert.AreEqual(false, result); // Kiểm tra trạng thái đã được cập nhật thành 1
        }
        [TestMethod]
        public void XoaPhieuNhapThuoc_Existing_UpdatesData()
        {
            // Arrange
            int SoPhieuNhap = 1;
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 7, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));
            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs.Find(SoPhieuNhap)).Returns(phieuNhap1);
            // Act
            var result = phieuNhapThuocDAL.XoaPhieuNhap(SoPhieuNhap);

            // Assert
            mockDbContext.Verify(d => d.SaveChanges(), Times.Once);
            mockDbContext.Verify(d => d.PHIEUNHAPTHUOCs.Remove(phieuNhap1), Times.Once);
           
        }
        [TestMethod]
        public void XoaPhieuNhapThuoc_NotExisting()
        {
            // Arrange
            int SoPhieuNhap = 3;
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 7, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 2 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));
            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs.Find(SoPhieuNhap)).Returns((PHIEUNHAPTHUOC)null);
            // Act
            var result = phieuNhapThuocDAL.XoaPhieuNhap(SoPhieuNhap);

            // Assert
            mockDbContext.Verify(d => d.SaveChanges(), Times.Never);
            mockDbContext.Verify(d => d.PHIEUNHAPTHUOCs.Remove(phieuNhap1), Times.Never);

        }
        [TestMethod]
        public void GetTongtien_ReturnsTongTienFromPHIEUNHAPTHUOC()
        {
            var phieuNhap1 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 1, TongTien = 1000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 1 };
            var phieuNhap2 = new PHIEUNHAPTHUOC() { SoPhieuNhapThuoc = 7, TongTien = 2000000, NgayNhap = new DateTime(2023, 11, 12), TrangThai = 0 };
            var expectedData = new List<PHIEUNHAPTHUOC> { phieuNhap1, phieuNhap2 };

            mockDbContext.Setup(db => db.PHIEUNHAPTHUOCs).Returns(MockDbSet(expectedData));

            var result = phieuNhapThuocDAL.getTongtien(phieuNhap1);

            Assert.AreEqual(phieuNhap1.TongTien, result);
        }

    }
}
