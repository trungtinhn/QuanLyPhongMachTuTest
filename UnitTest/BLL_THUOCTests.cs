using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class BLL_THUOCTests
    {
        private Mock<IDAL_THUOC> mockdalThuoc;
        private BLL_THUOC bLL_THUOC;
        [TestInitialize]
        public void SetUp()
        {
            mockdalThuoc = new Mock<IDAL_THUOC>();
            bLL_THUOC = new BLL_THUOC(mockdalThuoc.Object);
        }
        [TestMethod]
        public void CapNhatSoLuongTon_Quantity_ReturnsTrue()
        {
            // Arrange
            int idThuoc = 1;
            int soLuongCapNhat = 10;
            mockdalThuoc.Setup(d => d.CapNhatSoLuongTon(idThuoc, soLuongCapNhat)).Returns(true);

            // Act
            bool result = bLL_THUOC.CapNhatSoLuongTon(idThuoc, soLuongCapNhat);

            // Assert
            Assert.IsTrue(result);
            mockdalThuoc.Verify(bll => bll.CapNhatSoLuongTon(idThuoc, soLuongCapNhat), Times.Once);
        }
        [TestMethod]
        public void LayDanhSachThuoc_ValidIdLoaiThuoc_ReturnsListOfThuoc()
        {
            //// Arrange
            var expectedThuocs = new List<dynamic>{
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
            };
            mockdalThuoc.Setup(d => d.LayDanhSachThuoc(1)).Returns(expectedThuocs);
            // Act
            var result = bLL_THUOC.LayDanhSachThuoc(1);
            // Assert
            Assert.AreEqual(expectedThuocs, result);
        }
        [TestMethod]
        public void LayThuocByMa_ValidMaThuoc_ReturnsThuoc()
        {
            //// Arrange
            string mathuoc = "T123";
            var expectedThuocs =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            mockdalThuoc.Setup(d => d.LayThuocByMa(mathuoc)).Returns(expectedThuocs);
            // Act
            var result = bLL_THUOC.LayThuocByMa(mathuoc);
            // Assert
            Assert.AreEqual(expectedThuocs, result);
        }
        [TestMethod]
        public void LayThongTinThuoc_ValidTenThuoc_ReturnsThuoc()
        {
            //// Arrange
            string tenthuoc = "ThuocABC";
            var expectedThuocs =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            mockdalThuoc.Setup(d => d.LayThongTinThuoc(tenthuoc)).Returns(expectedThuocs);
            // Act
            var result = bLL_THUOC.LayThongTinThuoc(tenthuoc);
            // Assert
            Assert.AreEqual(expectedThuocs, result);
        }
        [TestMethod]
        public void LayThuoc_ValidIdThuoc_ReturnsThuoc()
        {
            //// Arrange
            int id = 1;
            var expectedThuocs =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            mockdalThuoc.Setup(d => d.LayThuocById(id)).Returns(expectedThuocs);
            // Act
            var result = bLL_THUOC.LayThuocById(id);
            // Assert
            Assert.AreEqual(expectedThuocs, result);
        }
        [TestMethod]
        public void ThemThuoc_ValidThuoc_UpdatesDatabase()
        {
            // Arrange
            var expectedThuoc =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            // Act
            var result = bLL_THUOC.Add(expectedThuoc);
            // Assert
            mockdalThuoc.Verify(x => x.Add(expectedThuoc), Times.Once);
        }
        [TestMethod]
        public void CapNhatThuoc_ValidThuoc_UpdatesDatabase()
        {
            // Arrange
            var expectedThuoc =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            mockdalThuoc.Setup(d => d.KiemTra(expectedThuoc)).Returns(true);
            // Act
            var result = bLL_THUOC.CapNhat(expectedThuoc);
            // Assert
            Assert.IsTrue(result);
            mockdalThuoc.Verify(x => x.CapNhat(expectedThuoc), Times.Once);
        }
        [TestMethod]
        public void Check_ExistingTen_ReturnsTrue()
        {
            // Arrange
            string tenBenh = "ThuocABC";
            var expectedThuoc =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            mockdalThuoc.Setup(d => d.Check(tenBenh)).Returns(true);
            // Act
            var result = bLL_THUOC.Check(tenBenh);
            // Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void Check_NotExistingTen_ReturnsFalse()
        {
            // Arrange
            string tenBenh = "Thuoc ABC";
            var expectedThuoc =
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                };
            mockdalThuoc.Setup(d => d.Check(tenBenh)).Returns(false);
            // Act
            var result = bLL_THUOC.Check(tenBenh);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GetThuocSapHet_ReturnsListOfThuoc()
        {
            // Arrange

            // Act
            var result = bLL_THUOC.getThuocSapHet();
            // Assert
            mockdalThuoc.Verify(d => d.getThuocSapHet(), Times.Once());
        }
        [TestMethod]
        public void LayDanhSachThuoc_ReturnListThuoc()
        {
            // Arrange
            var expectedResult = new List<THUOC>()
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                }
            };
            mockdalThuoc.Setup(d => d.Getall()).Returns(expectedResult);
            // Act
            var result = bLL_THUOC.getall();
            // Assert
            Assert.AreEqual(result, expectedResult);
        }
        [TestMethod]
        public void CapNhatSoLuongTon_EnoughQuantity_ReturnsTrue()
        {
            //
            int id = 1;
            int SoLuongTon = 3;
            var expected = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            mockdalThuoc.Setup(d => d.CapNhatSoLuongTon(id, SoLuongTon)).Returns(true);
            //
            var result = bLL_THUOC.CapNhatSoLuongTon(id, SoLuongTon);
            //
            Assert.IsTrue(result);
            mockdalThuoc.Verify(d => d.CapNhatSoLuongTon(id,SoLuongTon), Times.Once()); 

        }
        [TestMethod]
        public void CapNhatSoLuongTon_NotEnoughQuantity_ReturnsFalse()
        {
            //
            int id = 1;
            int SoLuongTon = 3;
            var expected = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            mockdalThuoc.Setup(d => d.CapNhatSoLuongTon(id, SoLuongTon)).Returns(false);
            //
            var result = bLL_THUOC.CapNhatSoLuongTon(id, SoLuongTon);
            //
            Assert.IsFalse(result);

        }
        [TestMethod] 
        public void TraCuuThuoc_Existing_ReturnTrue()
        {
            // arrange
            var expected = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            mockdalThuoc.Setup( d => d.KiemTra(expected)).Returns(true);
            // Act
            var result = bLL_THUOC.TracuuCD(expected);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TraCuuThuoc_NotExisting_ReturnFalse()
        {
            var expected = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            mockdalThuoc.Setup(d => d.KiemTra(expected)).Returns(false);
            // Act
            var result = bLL_THUOC.TracuuCD(expected);
            // Assert
            Assert.IsFalse(result);
        }

    }
}
