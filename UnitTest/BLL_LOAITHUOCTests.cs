using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using BLL;
using System.Data.Entity.Infrastructure;

namespace UnitTest
{
    [TestClass]
    public class BLL_LOAITHUOCTests
    {
        private Mock<IDAL_LOAITHUOC> mockLoaiThuocDAL;
        private BLL_LOAITHUOC loaiThuocBLL;

        [TestInitialize]
        public void Setup()
        {
            mockLoaiThuocDAL = new Mock<IDAL_LOAITHUOC>();
            loaiThuocBLL = new BLL_LOAITHUOC(mockLoaiThuocDAL.Object);
        }
        [TestMethod]
        public void LayDanhSachLoaiThuoc_Test()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };
            mockLoaiThuocDAL.Setup(d => d.LayDanhSachLoaiThuoc()).Returns(danhsachLoaiThuoc); // Thiết lập phương thức LayDanhSachLoaiThuoc trên mockLoaiThuocDAL để trả về danh sách kết quả mong đợi

            // Act
            var result = loaiThuocBLL.LayDanhSachLoaiThuoc();

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void LayLoaiThuoc_ValidMaLoaiThuoc_ReturnsLoaiThuoc()
        {
            // Arrange
            string maloaithuoc = "LT1";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockLoaiThuocDAL.Setup(d => d.LayLoaiThuoc(maloaithuoc)).Returns(loaithuoc1);

            // Act
            var result = loaiThuocBLL.LayLoaiThuoc(maloaithuoc);

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

            mockLoaiThuocDAL.Setup(d => d.LayTenLoaiThuoc(id)).Returns(loaithuoc1.TenLoaiThuoc);

            // Act
            var result = loaiThuocBLL.LayTenLoaiThuoc(id);

            // Assert
            Assert.AreEqual(loaithuoc1.TenLoaiThuoc, result);
        }
        [TestMethod]
        public void ThemLoaiThuoc_ReturnTrue()
        {
            // Arrange
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            // Act
            var b = loaiThuocBLL.Add(loaiThuoc);

            // Assert
            Assert.AreEqual(b, true);
            mockLoaiThuocDAL.Verify(d => d.Add(loaiThuoc), Times.Once);
        }
        [TestMethod]
        public void ThemLoaiThuoc_ThrowsException_ReturnFalse()
        {
            // Arrange
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            mockLoaiThuocDAL.Setup(d => d.Add(loaiThuoc)).Throws<Exception>();
            // Act
            var b = loaiThuocBLL.Add(loaiThuoc);

            // Assert
            Assert.AreEqual(b, false);
        }
        [TestMethod]
        public void Check_ExistingTenLoaiThuoc_ReturnsTrue()
        {
            string TenLoaiThuoc = "Loại thuốc 1";
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            mockLoaiThuocDAL.Setup(d=> d.Check(TenLoaiThuoc)).Returns(true);

            var result = loaiThuocBLL.Check(TenLoaiThuoc);

            Assert.IsTrue(result);
            
        }
        [TestMethod]
        public void Check_NotExistingTenLoaiThuoc_ReturnsFalse()
        {
            string TenLoaiThuoc = "Loại thuốc 1";
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            mockLoaiThuocDAL.Setup(d => d.Check(TenLoaiThuoc)).Returns(false);

            var result = loaiThuocBLL.Check(TenLoaiThuoc);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CapNhatLoaiThuoc_ValidLoaiThuoc_ReturnTrue()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(true);

            var result = loaiThuocBLL.CapNhat(loaiThuoc);

            mockLoaiThuocDAL.Verify( d=> d.CapNhat(loaiThuoc), Times.Once );
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CapNhatLoaiThuoc_NotValidLoaiThuoc_ReturnFalse()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(false);

            var result = loaiThuocBLL.CapNhat(loaiThuoc);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CapNhatLoaiThuoc_ThrowsException_ReturnFalse()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(false);
            mockLoaiThuocDAL.Setup(d => d.CapNhat(loaiThuoc)).Throws(new DbUpdateException());
            var result = loaiThuocBLL.CapNhat(loaiThuoc);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void XoaLoaiThuoc_ExixtingLoaiThuoc_ReturnTrue()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(true);

            var result = loaiThuocBLL.Xoa(loaiThuoc);
            Assert.IsTrue(result);
            mockLoaiThuocDAL.Verify(d=> d.Xoa(loaiThuoc), Times.Once());
        }
        [TestMethod]
        public void XoaLoaiThuoc_NotExixtingLoaiThuoc_ReturnFalse()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(false);

            var result = loaiThuocBLL.Xoa(loaiThuoc);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void XoaLoaiThuoc_ThrowsException_ReturnFalse()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(false);
            mockLoaiThuocDAL.Setup(d => d.Xoa(loaiThuoc)).Throws(new DbUpdateException());

            var result = loaiThuocBLL.Xoa(loaiThuoc);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Check_ExixtingLoaiThuoc_ReturnTrue()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(true);

            var result = loaiThuocBLL.TracuuCD(loaiThuoc);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_NotExixtingLoaiThuoc_ReturnFale()
        {
            var loaiThuoc = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };

            mockLoaiThuocDAL.Setup(d => d.KiemTra(loaiThuoc)).Returns(false);

            var result = loaiThuocBLL.TracuuCD(loaiThuoc);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void LayThongTinLoaiThuoc_ExistingTenLoaiThuoc_ReturnsLoaiThuoc()
        {
            // Arrange
            string TenLoaiThuoc = "Loại thuốc 1";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };


            mockLoaiThuocDAL.Setup(d => d.GetDataByten(TenLoaiThuoc)).Returns(loaithuoc1 );

            // Act
            var result = loaiThuocBLL.GetbyTen(TenLoaiThuoc);

            // Assert
            Assert.AreEqual(loaithuoc1, result);
        }
        [TestMethod]
        public void LayThongTinLoaiThuoc_NotExistingTenLoaiThuoc_ReturnsNull()
        {
            // Arrange
            string TenLoaiThuoc = "Loại thuốc 2";
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };


            mockLoaiThuocDAL.Setup(d => d.GetDataByten(TenLoaiThuoc)).Returns((LOAITHUOC)null);

            // Act
            var result = loaiThuocBLL.GetbyTen(TenLoaiThuoc);

            // Assert
            Assert.AreEqual(null, result) ;
        }
        [TestMethod]
        public void GetData_ReturnsListOfLOAITHUOC()
        {
            // Arrange
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockLoaiThuocDAL.Setup(d => d.GetData()).Returns(danhsachLoaiThuoc);
            // Act
            var result = loaiThuocBLL.GetData();

            // Assert
            Assert.AreEqual(danhsachLoaiThuoc.Count, result.Count);
            for(int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(danhsachLoaiThuoc[i].id, result[i].id );
            }
        }
        [TestMethod]
        public void GetDataByMa_ValidIdLoaiThuoc_ReturnsLOAITHUOC()
        {
            // Arrange
            int id = 1;
            var loaithuoc1 = new LOAITHUOC { id = 1, MaLoaiThuoc = "LT1", TenLoaiThuoc = "Loại thuốc 1" };
            var loaithuoc2 = new LOAITHUOC { id = 2, MaLoaiThuoc = "LT2", TenLoaiThuoc = "Loại thuốc 2" };
            var danhsachLoaiThuoc = new List<LOAITHUOC> { loaithuoc1, loaithuoc2 };

            mockLoaiThuocDAL.Setup(d=>d.GetDataByMa(id)).Returns(loaithuoc1 );

            // Act
            var result = loaiThuocBLL.getLTbyID(id);

            // Assert
            Assert.AreEqual(loaithuoc1, result);
        }
    }

}

