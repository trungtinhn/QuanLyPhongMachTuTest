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
    public class DAL_BENHNHANTests
    {
        private DAL_BENHNHAN dalBenhNhan;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<BENHNHAN>> benhNhanDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            benhNhanDbSetMock = new Mock<DbSet<BENHNHAN>>();
            dalBenhNhan = new DAL_BENHNHAN(dbContextMock.Object);

            var benhNhanList = new List<BENHNHAN>
    {
        new BENHNHAN { id = 1, MaBenhNhan = "BN1", HoTenBenhNhan = "Benh Nhan 1", GioiTinh = "Nam", NgaySinh = new DateTime(1990, 1, 1), DiaChi = "Dia chi 1" },
        new BENHNHAN { id = 2, MaBenhNhan = "BN2", HoTenBenhNhan = "Benh Nhan 2", GioiTinh = "Nu", NgaySinh = new DateTime(1995, 5, 5), DiaChi = "Dia chi 2" }
    };

            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.Provider).Returns(benhNhanList.AsQueryable().Provider);
            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.Expression).Returns(benhNhanList.AsQueryable().Expression);
            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.ElementType).Returns(benhNhanList.AsQueryable().ElementType);
            benhNhanDbSetMock.As<IQueryable<BENHNHAN>>().Setup(m => m.GetEnumerator()).Returns(benhNhanList.AsQueryable().GetEnumerator());
            dbContextMock.Setup(m => m.BENHNHANs).Returns(benhNhanDbSetMock.Object);
        }

        [TestMethod]
        public void LayThongTinBenhNhan_ShouldReturnBenhNhan_WhenMaBenhNhanExists()
        {
            // Arrange

            // Act
            var result = dalBenhNhan.LayThongTinBenhNhan("BN1");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("BN1", result.MaBenhNhan);
            // Kiểm tra các thuộc tính khác của BENHNHAN tương ứng
            Assert.AreEqual("Benh Nhan 1", result.HoTenBenhNhan);
            Assert.AreEqual("Nam", result.GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result.NgaySinh);
            Assert.AreEqual("Dia chi 1", result.DiaChi);
        }

        [TestMethod]
        public void LayThongTinBenhNhan_ShouldReturnNull_WhenMaBenhNhanNotExists()
        {
            // Arrange

            // Act
            var result = dalBenhNhan.LayThongTinBenhNhan("NonExistentID");

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnAllPatients_WhenFilterTypeIsAll()
        {
            // Arrange


            // Act
            var result = dalBenhNhan.LayDanhSachBenhNhan("Tất cả", "", DateTime.Now);

            // Assert
            Assert.AreEqual(2, result.Count);
            // Kiểm tra các thuộc tính của BENHNHAN trong danh sách
            Assert.AreEqual("BN1", result[0].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 1", result[0].HoTenBenhNhan);
            Assert.AreEqual("Nam", result[0].GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result[0].NgaySinh);
            Assert.AreEqual("Dia chi 1", result[0].DiaChi);

            Assert.AreEqual("BN2", result[1].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 2", result[1].HoTenBenhNhan);
            Assert.AreEqual("Nu", result[1].GioiTinh);
            Assert.AreEqual(new DateTime(1995, 5, 5), result[1].NgaySinh);
            Assert.AreEqual("Dia chi 2", result[1].DiaChi);
        }

        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnPatientsFilteredByMaBenhNhan_WhenFilterTypeIsMaBenhNhan()
        {
            // Arrange


            // Act
            var result = dalBenhNhan.LayDanhSachBenhNhan("Mã bệnh nhân", "BN1", DateTime.Now);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("BN1", result[0].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 1", result[0].HoTenBenhNhan);
            Assert.AreEqual("Nam", result[0].GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result[0].NgaySinh);
            Assert.AreEqual("Dia chi 1", result[0].DiaChi);
        }
        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnPatientsFilteredByTenBenhNhan_WhenFilterTypeIsTenBenhNhan()
        {
            // Arrange

            // Act
            var result = dalBenhNhan.LayDanhSachBenhNhan("Tên bệnh nhân", "Benh Nhan 1", DateTime.Now);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("BN1", result[0].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 1", result[0].HoTenBenhNhan);
            Assert.AreEqual("Nam", result[0].GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result[0].NgaySinh);
            Assert.AreEqual("Dia chi 1", result[0].DiaChi);
        }

        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnPatientsFilteredByGioiTinh_WhenFilterTypeIsGioiTinh()
        {
            // Arrange

            // Act
            var result = dalBenhNhan.LayDanhSachBenhNhan("Giới tính", "Nam", DateTime.Now);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("BN1", result[0].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 1", result[0].HoTenBenhNhan);
            Assert.AreEqual("Nam", result[0].GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result[0].NgaySinh);
            Assert.AreEqual("Dia chi 1", result[0].DiaChi);
        }

        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnPatientsFilteredByNgaySinh_WhenFilterTypeIsNgaySinh()
        {
            // Arrange

            // Act
            var result = dalBenhNhan.LayDanhSachBenhNhan("Ngày sinh", "", new DateTime(1990, 1, 1));

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("BN1", result[0].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 1", result[0].HoTenBenhNhan);
            Assert.AreEqual("Nam", result[0].GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result[0].NgaySinh);
            Assert.AreEqual("Dia chi 1", result[0].DiaChi);
        }

        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnPatientsFilteredByDiaChi_WhenFilterTypeIsDiaChi()
        {
            // Arrange


            // Act
            var result = dalBenhNhan.LayDanhSachBenhNhan("Địa chỉ", "Dia chi 1", DateTime.Now);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("BN1", result[0].MaBenhNhan);
            Assert.AreEqual("Benh Nhan 1", result[0].HoTenBenhNhan);
            Assert.AreEqual("Nam", result[0].GioiTinh);
            Assert.AreEqual(new DateTime(1990, 1, 1), result[0].NgaySinh);
            Assert.AreEqual("Dia chi 1", result[0].DiaChi);
        }
        [TestMethod]
        public void ThemBenhNhan_ShouldAddPatient_WhenPatientIsNotNull()
        {
            // Arrange
            var benhNhan = new BENHNHAN
            {
                MaBenhNhan = "BN1",
                HoTenBenhNhan = "Benh Nhan 1",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1990, 1, 1),
                DiaChi = "Dia chi 1"
            };

            dbContextMock.Setup(m => m.BENHNHANs.Add(It.IsAny<BENHNHAN>())).Verifiable();
            dbContextMock.Setup(m => m.SaveChanges()).Verifiable();

            // Act
            dalBenhNhan.ThemBenhNhan(benhNhan);

            // Assert
            dbContextMock.Verify();
        }

        [TestMethod]
        public void ThemBenhNhan_ShouldNotAddPatient_WhenPatientIsNull()
        {
            // Arrange
            BENHNHAN benhNhan = null;

            dbContextMock.Setup(m => m.BENHNHANs.Add(It.IsAny<BENHNHAN>())).Verifiable();
            dbContextMock.Setup(m => m.SaveChanges()).Verifiable();

            // Act
            dalBenhNhan.ThemBenhNhan(benhNhan);

            // Assert
            dbContextMock.Verify(m => m.BENHNHANs.Add(It.IsAny<BENHNHAN>()), Times.Never);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Never);
        }
        [TestMethod]
        public void KiemTraBenhNhan_ShouldReturnTrue_WhenPatientExists()
        {
            // Arrange
            string maBenhNhan = "BN1";
            BENHNHAN benhNhan = new BENHNHAN { MaBenhNhan = maBenhNhan };

            // Act
            bool result = dalBenhNhan.KiemTraBenhNhan(benhNhan);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CapNhatBenhNhan_ShouldUpdatePatient_WhenPatientExists()
        {
            // Arrange
            BENHNHAN benhNhanToUpdate = new BENHNHAN
            {
                MaBenhNhan = "BN1",
                HoTenBenhNhan = "Updated Benh Nhan",
                NgaySinh = new DateTime(1990, 1, 1),
                DiaChi = "Updated Dia chi",
                GioiTinh = "Updated Nam"
            };

            // Act
            dalBenhNhan.CapNhatBenhNhan(benhNhanToUpdate);

            // Assert
            BENHNHAN updatedBenhNhan = dbContextMock.Object.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhanToUpdate.MaBenhNhan);
            Assert.IsNotNull(updatedBenhNhan);
            Assert.AreEqual(benhNhanToUpdate.HoTenBenhNhan, updatedBenhNhan.HoTenBenhNhan);
            Assert.AreEqual(benhNhanToUpdate.NgaySinh, updatedBenhNhan.NgaySinh);
            Assert.AreEqual(benhNhanToUpdate.DiaChi, updatedBenhNhan.DiaChi);
            Assert.AreEqual(benhNhanToUpdate.GioiTinh, updatedBenhNhan.GioiTinh);
        }
        [TestMethod]
        public void XoaBenhNhan_ShouldRemovePatient_WhenPatientExists()
        {
            // Arrange
            BENHNHAN benhNhanToRemove = new BENHNHAN { id = 1, MaBenhNhan = "BN1", HoTenBenhNhan = "Benh Nhan 1", GioiTinh = "Nam", NgaySinh = new DateTime(1990, 1, 1), DiaChi = "Dia chi 1" };
            dbContextMock.Setup(m => m.BENHNHANs.Find(benhNhanToRemove.id)).Returns(benhNhanToRemove);
            dbContextMock.Setup(m => m.BENHNHANs.Find(benhNhanToRemove));

            // Act
            dalBenhNhan.XoaBenhNhan(benhNhanToRemove);

            // Assert
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
