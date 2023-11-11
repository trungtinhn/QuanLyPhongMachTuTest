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
    public class BLL_CACHDUNGTests
    {
        [TestMethod]
        public void AddCachDung_ShouldReturnTrue_WhenAddIsSuccessful()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.AddCachDung(It.IsAny<CACHDUNG>()));

            // Act
            bool result = cachDungBLL.AddCachDung(mockCachDung.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddCachDung_ShouldReturnFalse_WhenAddFails()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.AddCachDung(It.IsAny<CACHDUNG>()))
                .Throws(new Exception("Simulated exception during addition"));

            // Act
            bool result = cachDungBLL.AddCachDung(mockCachDung.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckCachDung_ShouldReturnTrue_WhenCachDungExists()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var cachDungName = "ExistingCachDung";
            mockCachDungDAL
                .Setup(x => x.CheckCachDung(cachDungName))
                .Returns(true);

            // Act
            bool result = cachDungBLL.CheckCachDung(cachDungName);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckCachDung_ShouldReturnFalse_WhenCachDungDoesNotExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var cachDungName = "NonExistingCachDung";
            mockCachDungDAL
                .Setup(x => x.CheckCachDung(cachDungName))
                .Returns(false);

            // Act
            bool result = cachDungBLL.CheckCachDung(cachDungName);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CapNhatCachDung_ShouldReturnTrue_WhenUpdateIsSuccessful()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(true);
            mockCachDungDAL
                .Setup(x => x.CapNhatCachDung(It.IsAny<CACHDUNG>()));

            // Act
            bool result = cachDungBLL.CapNhatCachDung(mockCachDung.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CapNhatCachDung_ShouldReturnFalse_WhenCachDungDoesNotExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(false);

            // Act
            bool result = cachDungBLL.CapNhatCachDung(mockCachDung.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CapNhatCachDung_ShouldReturnFalse_WhenUpdateFails()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(true);
            mockCachDungDAL
                .Setup(x => x.CapNhatCachDung(It.IsAny<CACHDUNG>()))
                .Throws(new Exception("Simulated exception during update"));

            // Act
            bool result = cachDungBLL.CapNhatCachDung(mockCachDung.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void XoaCachDung_ShouldReturnTrue_WhenDeleteIsSuccessful()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(true);
            mockCachDungDAL
                .Setup(x => x.XoaCachDung(It.IsAny<CACHDUNG>()));

            // Act
            bool result = cachDungBLL.XoaCachDung(mockCachDung.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void XoaCachDung_ShouldReturnFalse_WhenCachDungDoesNotExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(false);

            // Act
            bool result = cachDungBLL.XoaCachDung(mockCachDung.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void XoaCachDung_ShouldReturnFalse_WhenDeleteFails()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(true);
            mockCachDungDAL
                .Setup(x => x.XoaCachDung(It.IsAny<CACHDUNG>()))
                .Throws(new Exception("Simulated exception during deletion"));

            // Act
            bool result = cachDungBLL.XoaCachDung(mockCachDung.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TracuuCD_ShouldReturnTrue_WhenCachDungExists()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(true);

            // Act
            bool result = cachDungBLL.TracuuCD(mockCachDung.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TracuuCD_ShouldReturnFalse_WhenCachDungDoesNotExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new Mock<CACHDUNG>();
            mockCachDungDAL
                .Setup(x => x.KiemTraCachDung(It.IsAny<CACHDUNG>()))
                .Returns(false);

            // Act
            bool result = cachDungBLL.TracuuCD(mockCachDung.Object);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GetAllThuoc_ShouldReturnListOfCachDung()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDungList = new List<CACHDUNG>
        {
            new CACHDUNG {},
            new CACHDUNG {},
        };

            mockCachDungDAL
                .Setup(x => x.getall())
                .Returns(mockCachDungList);

            // Act
            List<CACHDUNG> result = cachDungBLL.GetAllThuoc();

            // Assert
            CollectionAssert.AreEqual(mockCachDungList, result);
        }

        [TestMethod]
        public void GetByTen_ShouldReturnCachDungWhenExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new CACHDUNG {};
            var ten = "SampleTen";
            mockCachDungDAL
                .Setup(x => x.GetByTen(ten))
                .Returns(mockCachDung);

            // Act
            CACHDUNG result = cachDungBLL.GetByTen(ten);

            // Assert
            Assert.AreEqual(mockCachDung, result);
        }

        [TestMethod]
        public void GetByTen_ShouldReturnNullWhenNotExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var ten = "NonExistingTen";
            mockCachDungDAL
                .Setup(x => x.GetByTen(ten))
                .Returns((CACHDUNG)null);

            // Act
            CACHDUNG result = cachDungBLL.GetByTen(ten);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void getCDbyID_ShouldReturnCachDungWhenExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var mockCachDung = new CACHDUNG {};
            var idMaCachDung = 1;
            mockCachDungDAL
                .Setup(x => x.getCDbyID(idMaCachDung))
                .Returns(mockCachDung);

            // Act
            CACHDUNG result = cachDungBLL.getCDbyID(idMaCachDung);

            // Assert
            Assert.AreEqual(mockCachDung, result);
        }

        [TestMethod]
        public void getCDbyID_ShouldReturnNullWhenNotExist()
        {
            // Arrange
            var mockCachDungDAL = new Mock<IDAL_CACHDUNG>();
            var cachDungBLL = new BLL_CACHDUNG(mockCachDungDAL.Object);
            var idMaCachDung = 999; 
            mockCachDungDAL
                .Setup(x => x.getCDbyID(idMaCachDung))
                .Returns((CACHDUNG)null);

            // Act
            CACHDUNG result = cachDungBLL.getCDbyID(idMaCachDung);

            // Assert
            Assert.IsNull(result);
        }
    }
}
