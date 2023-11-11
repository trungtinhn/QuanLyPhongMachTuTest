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
    public class BLL_THAMSOTests
    {
        private Mock<IDAL_THAMSO> mockdalThamso;
        private BLL_THAMSO bLL_THAMSO;
        [TestInitialize]
        public void SetUp()
        {
            mockdalThamso = new Mock<IDAL_THAMSO>();
            bLL_THAMSO = new BLL_THAMSO(mockdalThamso.Object);
        }
        [TestMethod]
        public void ThayDoiQuyDinh_ValidInput_CallsThayDoiThamSo()
        {
            // Tạo một đối tượng THAMSO giả lập
            THAMSO thamSo = new THAMSO { id = 1, TienKham = 200, SoBenhNhanToiDa = 100, SoLuongSapHet = 10 };

            // Gọi phương thức ThayDoiQuyDinh từ BLL_THAMSO
            bLL_THAMSO.ThayDoiQuyDinh(300, 150, 15);

            // Kiểm tra xem phương thức ThayDoiThamSo đã được gọi trên mock object
            mockdalThamso.Verify(x => x.ThayDoiThamSo(300, 150, 15), Times.Once);
        }
        [TestMethod]
        public void LayThamSo_ValidId_CallsLayThamSo()
        {
            // Tạo một đối tượng THAMSO giả lập để trả về
            THAMSO expectedThamSo = new THAMSO { id = 1, TienKham = 100, SoBenhNhanToiDa = 50, SoLuongSapHet = 5 };

            // Thiết lập hành vi cho phương thức LayThamSo trên mock object
            mockdalThamso.Setup(x => x.LayThamSo(1)).Returns(expectedThamSo);

            // Gọi phương thức LayThamSo từ BLL_THAMSO và kiểm tra kết quả
            THAMSO result = bLL_THAMSO.LayThamSo(1);

            // Kiểm tra xem phương thức LayThamSo đã được gọi trên mock object
            mockdalThamso.Verify(x => x.LayThamSo(1), Times.Once);

            // Kiểm tra kết quả trả về
            Assert.AreEqual(expectedThamSo, result);
        }
    }
}
