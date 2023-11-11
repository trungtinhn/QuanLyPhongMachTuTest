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
    public class DAL_THAMSOTests
    {
        private DAL_THAMSO dalThamso;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<THAMSO>> dbSetMock;
        [TestInitialize]
        public void SetUp()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            dbSetMock = new Mock<DbSet<THAMSO>>();
            dalThamso = new DAL_THAMSO(dbContextMock.Object);
        }
        [TestMethod]
        public void LayThamSo_ValidId_ReturnsThamSo()
        {
            // Arrange
            THAMSO expectedThamSo = new THAMSO { id = 1, TienKham = 100, SoBenhNhanToiDa = 50, SoLuongSapHet = 5 };
           
            dbContextMock.Setup(x => x.THAMSOes.Find(1)).Returns(expectedThamSo);

            // Act
            THAMSO result = dalThamso.LayThamSo(1);

            // Assert
            dbContextMock.Verify(x => x.THAMSOes.Find(1), Times.Once());
            Assert.AreEqual(expectedThamSo, result);
        }
        [TestMethod]
        public void ThayDoiThamSo_ValidInput_SavesChanges()
        {
            // Tạo một đối tượng THAMSO giả lập
            THAMSO thamSo = new THAMSO { id = 1, TienKham = 200, SoBenhNhanToiDa = 100, SoLuongSapHet = 10 };

            // Thiết lập hành vi cho phương thức Find trên mock object
            dbContextMock.Setup(x => x.THAMSOes.Find(1)).Returns(thamSo);

            // Act
            dalThamso.ThayDoiThamSo(300, 150, 15);

            // Kiểm tra xem phương thức Find đã được gọi trên mock object
            dbContextMock.Verify(x => x.THAMSOes.Find(1), Times.Once);

            // Kiểm tra xem các thuộc tính trong đối tượng THAMSO đã được cập nhật
            Assert.AreEqual(300, thamSo.TienKham);
            Assert.AreEqual(150, thamSo.SoBenhNhanToiDa);
            Assert.AreEqual(15, thamSo.SoLuongSapHet);

            // Kiểm tra xem phương thức SaveChanges đã được gọi trên mock object
            dbContextMock.Verify(x => x.SaveChanges(), Times.Once);
        }
    }
}
