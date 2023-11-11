using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace UnitTest
{
    [TestClass]
    public class BLL_DONVITests
    {
        private Mock<IDAL_DONVI> mockDonViDAL;
        private BLL_DONVI donViBLL;

        [TestInitialize]
        public void Setup()
        {
            mockDonViDAL = new Mock<IDAL_DONVI>();
            donViBLL = new BLL_DONVI(mockDonViDAL.Object);
        }

        [TestMethod]
        public void Add_ShouldReturnTrue_WhenAddingUnitIsSuccessful()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.Add(mockDonVi.Object))
                .Verifiable();

            // Act
            bool result = donViBLL.Add(mockDonVi.Object);

            // Assert
            Assert.IsTrue(result);
            mockDonViDAL.Verify();
        }

        [TestMethod]
        public void Add_ShouldReturnFalse_WhenAddingUnitFails()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.Add(mockDonVi.Object))
                .Throws(new Exception("Simulated exception"));

            // Act
            bool result = donViBLL.Add(mockDonVi.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ShouldReturnTrue_WhenUnitExists()
        {
            // Arrange
            var tenDonVi = "TestUnit";
            mockDonViDAL
                .Setup(x => x.Check(tenDonVi))
                .Returns(true);

            // Act
            bool result = donViBLL.Check(tenDonVi);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenUnitDoesNotExist()
        {
            // Arrange
            var tenDonVi = "NonExistentUnit";
            mockDonViDAL
                .Setup(x => x.Check(tenDonVi))
                .Returns(false);

            // Act
            bool result = donViBLL.Check(tenDonVi);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CapNhat_ShouldReturnTrue_WhenUpdatingUnitIsSuccessful()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.KiemTra(mockDonVi.Object))
                .Returns(true);
            mockDonViDAL
                .Setup(x => x.CapNhat(mockDonVi.Object))
                .Verifiable();

            // Act
            bool result = donViBLL.CapNhat(mockDonVi.Object);

            // Assert
            Assert.IsTrue(result);
            mockDonViDAL.Verify();
        }

        [TestMethod]
        public void CapNhat_ShouldReturnFalse_WhenUpdatingUnitFails()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.KiemTra(mockDonVi.Object))
                .Returns(true);
            mockDonViDAL
                .Setup(x => x.CapNhat(mockDonVi.Object))
                .Throws(new DbUpdateException("Simulated exception"));

            // Act
            bool result = donViBLL.CapNhat(mockDonVi.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Xoa_ShouldReturnTrue_WhenDeletingUnitIsSuccessful()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.KiemTra(mockDonVi.Object))
                .Returns(true);
            mockDonViDAL
                .Setup(x => x.Xoa(mockDonVi.Object))
                .Verifiable();

            // Act
            bool result = donViBLL.Xoa(mockDonVi.Object);

            // Assert
            Assert.IsTrue(result);
            mockDonViDAL.Verify();
        }

        [TestMethod]
        public void Xoa_ShouldReturnFalse_WhenDeletingUnitFails()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.KiemTra(mockDonVi.Object))
                .Returns(true);
            mockDonViDAL
                .Setup(x => x.Xoa(mockDonVi.Object))
                .Throws(new DbUpdateException("Simulated exception"));

            // Act
            bool result = donViBLL.Xoa(mockDonVi.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TracuuCD_ShouldReturnTrue_WhenUnitExists()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.KiemTra(mockDonVi.Object))
                .Returns(true);

            // Act
            bool result = donViBLL.TracuuCD(mockDonVi.Object);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TracuuCD_ShouldReturnFalse_WhenUnitDoesNotExist()
        {
            // Arrange
            var mockDonVi = new Mock<DONVI>();
            mockDonViDAL
                .Setup(x => x.KiemTra(mockDonVi.Object))
                .Returns(false);

            // Act
            bool result = donViBLL.TracuuCD(mockDonVi.Object);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetAllThuoc_ShouldReturnCorrectResult()
        {
            // Arrange
            var expectedResult = new List<DONVI>();
            mockDonViDAL
                .Setup(x => x.getall())
                .Returns(expectedResult);

            // Act
            List<DONVI> result = donViBLL.GetAllThuoc();

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GetByTen_ShouldReturnCorrectResult()
        {
            // Arrange
            var tenDonVi = "TestUnit";
            var expectedResult = new DONVI();
            mockDonViDAL
                .Setup(x => x.GetByten(tenDonVi))
                .Returns(expectedResult);

            // Act
            DONVI result = donViBLL.GetByTen(tenDonVi);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void getDVbyID_ShouldReturnCorrectResult()
        {
            // Arrange
            var idMaDonVi = 1;
            var expectedResult = new DONVI();
            mockDonViDAL
                .Setup(x => x.getDVbyID(idMaDonVi))
                .Returns(expectedResult);

            // Act
            DONVI result = donViBLL.getDVbyID(idMaDonVi);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
