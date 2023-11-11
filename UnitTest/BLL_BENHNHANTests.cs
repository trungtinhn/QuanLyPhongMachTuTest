using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace UnitTest
{
    [TestClass]
    public class BLL_BENHNHANTests
    {
        private Mock<IDAL_BENHNHAN> mockDBenhNhanDAL;
        private BLL_BENHNHAN benhNhanBLL;

        [TestInitialize]
        public void TestInitialize()
        {
            mockDBenhNhanDAL = new Mock<IDAL_BENHNHAN>();
            benhNhanBLL = new BLL_BENHNHAN(mockDBenhNhanDAL.Object);
        }

        [TestMethod]
        public void LayDanhSachBenhNhan_ShouldReturnAllPatients_WhenKieuLocIsTatCa()
        {
            // Arrange
            string kieuLoc = "Tất cả";
            string giaTri = "SomeValue";
            DateTime ngaySinh = DateTime.Now;
            mockDBenhNhanDAL
                .Setup(x => x.LayDanhSachBenhNhan(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>()))
                .Returns(new List<BENHNHAN>());

            // Act
            var result = benhNhanBLL.LayDanhSachBenhNhan(kieuLoc, giaTri, ngaySinh);

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ThemBenhNhan_ShouldReturnTrue_WhenAddingPatientIsSuccessful()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.ThemBenhNhan(It.IsAny<BENHNHAN>()))
                .Verifiable(); 

            // Act
            bool result = benhNhanBLL.ThemBenhNhan(benhNhan);

            // Assert
            Assert.IsTrue(result);
            mockDBenhNhanDAL.Verify();
        }

        [TestMethod]
        public void ThemBenhNhan_ShouldReturnFalse_WhenAddingPatientFails()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.ThemBenhNhan(It.IsAny<BENHNHAN>()))
                .Throws(new Exception("Simulated exception"));

            // Act
            bool result = benhNhanBLL.ThemBenhNhan(benhNhan);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CapNhatBenhNhan_ShouldReturnTrue_WhenUpdateIsSuccessful()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.KiemTraBenhNhan(It.IsAny<BENHNHAN>()))
                .Returns(true);
            mockDBenhNhanDAL
                .Setup(x => x.CapNhatBenhNhan(It.IsAny<BENHNHAN>()));

            // Act
            bool result = benhNhanBLL.CapNhatBenhNhan(benhNhan);

            // Assert
            Assert.IsTrue(result);
            mockDBenhNhanDAL.Verify(x => x.CapNhatBenhNhan(It.IsAny<BENHNHAN>()), Times.Once);
        }

        [TestMethod]
        public void CapNhatBenhNhan_ShouldReturnFalse_WhenUpdateFails()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.KiemTraBenhNhan(It.IsAny<BENHNHAN>()))
                .Returns(true);
            mockDBenhNhanDAL
                .Setup(x => x.CapNhatBenhNhan(It.IsAny<BENHNHAN>()))
                .Throws(new Exception("Simulated exception"));

            // Act
            bool result = benhNhanBLL.CapNhatBenhNhan(benhNhan);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CapNhatBenhNhan_ShouldReturnFalse_WhenPatientDoesNotExist()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.KiemTraBenhNhan(It.IsAny<BENHNHAN>()))
                .Returns(false);

            // Act
            bool result = benhNhanBLL.CapNhatBenhNhan(benhNhan);

            // Assert
            Assert.IsFalse(result);
            mockDBenhNhanDAL.Verify(x => x.CapNhatBenhNhan(It.IsAny<BENHNHAN>()), Times.Never);
        }
        [TestMethod]
        public void XoaBenhNhan_ShouldReturnTrue_WhenDeletionIsSuccessful()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.KiemTraBenhNhan(It.IsAny<BENHNHAN>()))
                .Returns(true);
            mockDBenhNhanDAL
                .Setup(x => x.XoaBenhNhan(It.IsAny<BENHNHAN>()))
                .Verifiable();

            // Act
            bool result = benhNhanBLL.XoaBenhNhan(benhNhan);

            // Assert
            Assert.IsTrue(result);
            mockDBenhNhanDAL.Verify();
        }

        [TestMethod]
        public void XoaBenhNhan_ShouldReturnFalse_WhenDeletionFails()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.KiemTraBenhNhan(It.IsAny<BENHNHAN>()))
                .Returns(true);
            mockDBenhNhanDAL
                .Setup(x => x.XoaBenhNhan(It.IsAny<BENHNHAN>()))
                .Throws(new Exception("Simulated exception"));

            // Act
            bool result = benhNhanBLL.XoaBenhNhan(benhNhan);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void XoaBenhNhan_ShouldReturnFalse_WhenPatientDoesNotExist()
        {
            // Arrange
            BENHNHAN benhNhan = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.KiemTraBenhNhan(It.IsAny<BENHNHAN>()))
                .Returns(false);

            // Act
            bool result = benhNhanBLL.XoaBenhNhan(benhNhan);

            // Assert
            Assert.IsFalse(result);
            mockDBenhNhanDAL.Verify(x => x.XoaBenhNhan(It.IsAny<BENHNHAN>()), Times.Never);
        }
        [TestMethod]
        public void LayThongTinBenhNhan_ByMaBenhNhan_ShouldReturnPatient()
        {
            // Arrange
            string maBenhNhan = "ABC123";
            BENHNHAN expectedPatient = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.LayThongTinBenhNhan(maBenhNhan))
                .Returns(expectedPatient);

            // Act
            BENHNHAN result = benhNhanBLL.LayThongTinBenhNhan(maBenhNhan);

            // Assert
            Assert.AreEqual(expectedPatient, result);
        }

        [TestMethod]
        public void LayThongTinBenhNhan_ByIdBenhNhan_ShouldReturnPatient()
        {
            // Arrange
            int idBenhNhan = 1;
            BENHNHAN expectedPatient = new BENHNHAN();
            mockDBenhNhanDAL
                .Setup(x => x.LayThongTinBenhNhan(idBenhNhan))
                .Returns(expectedPatient);

            // Act
            BENHNHAN result = benhNhanBLL.LayThongTinBenhNhan(idBenhNhan);

            // Assert
            Assert.AreEqual(expectedPatient, result);
        }

        [TestMethod]
        public void LayThongTinBenhNhan_ByMaBenhNhan_ShouldReturnNull_WhenPatientNotFound()
        {
            // Arrange
            string maBenhNhan = "NonExistentID";
            mockDBenhNhanDAL
                .Setup(x => x.LayThongTinBenhNhan(maBenhNhan))
                .Returns((BENHNHAN)null);

            // Act
            BENHNHAN result = benhNhanBLL.LayThongTinBenhNhan(maBenhNhan);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void LayThongTinBenhNhan_ByIdBenhNhan_ShouldReturnNull_WhenPatientNotFound()
        {
            // Arrange
            int idBenhNhan = 999;
            mockDBenhNhanDAL
                .Setup(x => x.LayThongTinBenhNhan(idBenhNhan))
                .Returns((BENHNHAN)null);

            // Act
            BENHNHAN result = benhNhanBLL.LayThongTinBenhNhan(idBenhNhan);

            // Assert
            Assert.IsNull(result);
        }
    }
}
