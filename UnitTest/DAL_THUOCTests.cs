using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Linq.Expressions;

namespace UnitTest
{
    [TestClass]
    public class DAL_THUOCTests
    {
        private DAL_THUOC dalThuoc;
        private Mock<QLPMTEntities> dbMock;
        private Mock<IDAL_THAMSO> dThamSoDALMock;
        private Mock<DbSet<THUOC>> dbSetMock;
        [TestInitialize]
        public void Setup()
        {
            // Tạo mock object cho QLPMTEntities
            dbMock = new Mock<QLPMTEntities>();
            // Tạo mock object cho DAL_THAMSO
            dThamSoDALMock = new Mock<IDAL_THAMSO>();
            dbSetMock = new Mock<DbSet<THUOC>>();
            // Tạo đối tượng DAL_THUOC với mock objects
            dalThuoc = new DAL_THUOC(dbMock.Object, dThamSoDALMock.Object);
        }
        [TestMethod]
        public void LayDanhSachThuoc_ValidIdLoaiThuoc_ReturnsListOfThuoc()
        {
            int idLoaiThuoc = 1;
            // Tạo danh sách thuốc giả lập để trả về
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "Thuốc ABC",
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
                    id = 2,
                    MaThuoc = "T123",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            var expectedThuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
            };
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Gọi phương thức LayDanhSachThuoc từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.LayDanhSachThuoc(idLoaiThuoc);

            // Kiểm tra kết quả trả về
            Assert.AreEqual(expectedThuocs.Count, result.Count);
            for (int i = 0; i < expectedThuocs.Count; i++)
            {
                Assert.AreEqual(expectedThuocs[i].idMaLoaiThuoc, result[i].idMaLoaiThuoc);
            }
        }
        [TestMethod]
        public void LayThuocByMa_ValidMaThuoc_ReturnsThuoc()
        {
            string MaThuoc = "T123";
            // Tạo danh sách thuốc giả lập để trả về
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "Thuốc ABC",
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            var expectedThuocs = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "Thuốc ABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Gọi phương thức LayDanhSachThuoc từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.LayThuocByMa(MaThuoc);

            // Kiểm tra kết quả trả về
            Assert.AreEqual(expectedThuocs.MaThuoc, result.MaThuoc);
        }
        [TestMethod]
        public void LayThuocByMa_ValidMaThuoc_ReturnsNull()
        {
            // Tạo danh sách thuốc giả lập để trả về
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "Thuốc ABC",
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            var expectedThuocs = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "Thuốc ABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);

            // Gọi phương thức LayDanhSachThuoc từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.LayThuocByMa("KhongTonTai");

            // Kiểm tra kết quả trả về
            Assert.AreEqual(null, result);
        }
        [TestMethod]
        public void LayThongTinThuoc_ValidTenThuoc_ReturnsThuoc()
        {
            string TenThuoc = "ThuocABC";
            // Tạo danh sách thuốc giả lập để trả về
            var Thuocs = new List<THUOC>
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            var expectedThuocs = new THUOC()
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
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Gọi phương thức LayDanhSachThuoc từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.LayThongTinThuoc(TenThuoc);

            // Kiểm tra kết quả trả về
            Assert.AreEqual(expectedThuocs.MaThuoc, result.MaThuoc);
        }
        [TestMethod]
        public void LayThongTinThuoc_NotValidTenThuoc_ReturnsThuoc()
        {
            string TenThuoc = "Khong Ton Tai";
            // Tạo danh sách thuốc giả lập để trả về
            var Thuocs = new List<THUOC>
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            var expectedThuocs = new THUOC()
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
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Gọi phương thức LayDanhSachThuoc từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.LayThongTinThuoc(TenThuoc);

            // Kiểm tra kết quả trả về
            Assert.AreEqual(null, result);
        }
        [TestMethod]

        public void LayThuoc_ValidIdThuoc_ReturnsThuoc()
        {
            int id = 1;
            // Tạo danh sách thuốc giả lập để trả về
            var expectedThuocs = new THUOC()
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
            dbMock.Setup(db => db.THUOCs.Find(id)).Returns(expectedThuocs);
            // Gọi phương thức LayDanhSachThuoc từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.LayThuocById(id);

            // Kiểm tra kết quả trả về
            Assert.AreEqual(expectedThuocs.id, result.id);
        }
        [TestMethod]
        public void ThemThuoc_ValidThuoc_UpdatesDatabase()
        {
            // Tạo một đối tượng THUOC giả lập để truyền vào phương thức
            var thuoc = new THUOC
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
            dbMock.Setup(m => m.THUOCs.Add(thuoc));
            // Gọi phương thức ThemThuoc từ DAL_THUOC
            dalThuoc.Add(thuoc);

            // Kiểm tra xem phương thức SaveChanges đã được gọi trên mock object dbMock hay chưa
            dbMock.Verify(x => x.THUOCs.Add(thuoc), Times.Once());
            dbMock.Verify(x => x.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void CapNhatThuoc_ValidThuoc_UpdatesDatabase()
        {
            var Thuocs = new List<THUOC>
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Tạo một đối tượng THUOC giả lập để truyền vào phương thức
            var thuoc = new THUOC
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "Thuoc da cap nhat",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 100,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            dbMock.Setup(m => m.THUOCs.Find(1)).Returns(thuoc);
            // Gọi phương thức CapNhatThuoc từ DAL_THUOC
            dalThuoc.CapNhat(thuoc);

            // Kiểm tra xem phương thức SaveChanges đã được gọi trên mock object dbMock hay chưa
            dbMock.Verify(x => x.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void Check_ExistingTen_ReturnsTrue()
        {
            var Thuocs = new List<THUOC>
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);

            // Gọi phương thức Check với một tên thuốc tồn tại
            bool result = dalThuoc.Check("ThuocABC");

            // Kiểm tra kết quả trả về
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void KiemTra_NotExistingThuoc_ReturnsFalse()
        {
            // Arange
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 5,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                }
            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());
            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);

            var expancted = new THUOC()
            {
                id = 2,
                MaThuoc = "T12345",
                TenThuoc = "Thuoc ABCD",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 5,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            // Act
            var result = dalThuoc.KiemTra(expancted);
            // Assert
            Assert.IsFalse(result);

        }
        [TestMethod]
        public void KiemTra_EmptyDb_ReturnsFalse()
        {
            // Arange
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                }
            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());
            dbMock.Setup(m => m.THUOCs).Returns((DbSet<THUOC>)null);

            var expancted = new THUOC()
            {
            };
            // Act
            var result = dalThuoc.KiemTra(expancted);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void KiemTra_ExistingThuoc_ReturnsTrue()
        {
            // Arange
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 5,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
                new THUOC()
                {
                    id = 3,
                    MaThuoc = "T12rjj",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 3,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());
            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);

            var expancted = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 3,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            // Act
            var result = dalThuoc.KiemTra(expancted);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_NotExistingTen_ReturnsFalse()
        {
            var Thuocs = new List<THUOC>
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
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 100,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },

            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);

            // Gọi phương thức Check với một tên thuốc khong tồn tại
            bool result = dalThuoc.Check("Thuoc A");

            // Kiểm tra kết quả trả về
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GetThuocSapHet_ReturnsListOfThuoc()
        {
            // Tạo danh sách thuốc giả lập để trả về
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 3,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
                new THUOC()
                {
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 8,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },
            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Tạo đối tượng THAMSO giả lập để trả về
            var expectedThamSo = new THAMSO { id = 1, TienKham = 100, SoBenhNhanToiDa = 50, SoLuongSapHet = 5 };
            var expectedThuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 3,
                    idMaCachDung = 1,
                    SoLuongTon = 4,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
            };
            // Thiết lập hành vi cho phương thức LayThamSo trên mock object dThamSoDALMock
            dThamSoDALMock.Setup(x => x.LayThamSo(1)).Returns(expectedThamSo);


            // Gọi phương thức getThuocSapHet từ DAL_THUOC và kiểm tra kết quả
            var result = dalThuoc.getThuocSapHet();

            // Kiểm tra kết quả trả về
            Assert.AreEqual(expectedThuocs.Count, result.Count);
        }
        [TestMethod]
        public void LayDanhSachThuoc_ReturnListThuoc()
        {
            // Arrange
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 3,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                },
                new THUOC()
                {
                    id = 2,
                    MaThuoc = "T324",
                    TenThuoc = "Thuốc ABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 8,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 2
                },
            };
            var expancted = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 3,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.AsQueryable().Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.AsQueryable().Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.AsQueryable().GetEnumerator());

            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            dbMock.Setup(m => m.THUOCs.Find(1)).Returns(expancted);
           
            // Act
            var result = dalThuoc.Getall();
            //
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void CapNhatSoLuongTon_EnoughQuantity_ReturnsTrue()
        {
            // Arange
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 5,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                }
            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());
            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);

            var expancted = new THUOC()
            {
                id = 1,
                MaThuoc = "T123",
                TenThuoc = "ThuocABC",
                idMaDonVi = 1,
                idMaCachDung = 1,
                SoLuongTon = 3,
                DonGia = 50,
                CongDung = "Điều trị bệnh X",
                HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                idMaLoaiThuoc = 1
            };

            dbMock.Setup(m => m.THUOCs.Find(1)).Returns(expancted);
            // Act
            bool result = dalThuoc.CapNhatSoLuongTon(1, 3);
            // Assert
            Assert.IsTrue(result);
            dbMock.Verify(m => m.SaveChanges(), Times.Once);
        }
        [TestMethod]
        public void CapNhatSoLuongTon_NotEnoughQuantity_ReturnsFalse()
        {
            // Arange
            var Thuocs = new List<THUOC>
            {
                new THUOC()
                {
                    id = 1,
                    MaThuoc = "T123",
                    TenThuoc = "ThuocABC",
                    idMaDonVi = 1,
                    idMaCachDung = 1,
                    SoLuongTon = 2,
                    DonGia = 50,
                    CongDung = "Điều trị bệnh X",
                    HuongDanSuDung = "Dùng 2 viên mỗi ngày",
                    idMaLoaiThuoc = 1
                }
            }.AsQueryable();
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Provider).Returns(Thuocs.Provider);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.Expression).Returns(Thuocs.Expression);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.ElementType).Returns(Thuocs.ElementType);
            dbSetMock.As<IQueryable<THUOC>>().Setup(m => m.GetEnumerator()).Returns(Thuocs.GetEnumerator());
            dbMock.Setup(m => m.THUOCs).Returns(dbSetMock.Object);
            // Act
            bool result = dalThuoc.CapNhatSoLuongTon(1, 3);
            // Assert
            Assert.IsFalse(result);
        }
    }
}
