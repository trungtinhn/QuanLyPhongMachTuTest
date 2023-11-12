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
    public class DAL_LOGINTests
    {
        private DAL_LOGIN dalLogin;
        private Mock<QLPMTEntities> dbContextMock;
        private Mock<DbSet<NGUOIDUNG>> dbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLPMTEntities>();
            dbSetMock = new Mock<DbSet<NGUOIDUNG>>();
            dalLogin = new DAL_LOGIN(dbContextMock.Object);
        }

        [TestMethod]    
        public void Login_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "testuser";
            string password = "testpassword";

            var nguoiDung = new List<NGUOIDUNG>
            {
                new NGUOIDUNG
                {
                    id = 1,
                    MaNguoiDung = "ND001",
                    TenNguoiDung = "Người Dùng 1",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "testuser",
                    MatKhau = "testpassword",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
                new NGUOIDUNG
                {
                    id = 2,
                    MaNguoiDung = "ND002",
                    TenNguoiDung = "Người Dùng 2",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "user",
                    MatKhau = "password",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
            }.AsQueryable();

            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Provider).Returns(nguoiDung.Provider);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Expression).Returns(nguoiDung.Expression);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.ElementType).Returns(nguoiDung.ElementType);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.GetEnumerator()).Returns(nguoiDung.GetEnumerator());

            dbContextMock.Setup(m => m.NGUOIDUNGs).Returns(dbSetMock.Object);

            // Act
            bool result = dalLogin.Login(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "testuser";
            string password = "wrongpassword";

            var nguoiDung = new List<NGUOIDUNG>
            {
                new NGUOIDUNG
                {
                    id = 1,
                    MaNguoiDung = "ND001",
                    TenNguoiDung = "Người Dùng 1",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "testuser",
                    MatKhau = "testpassword",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
                new NGUOIDUNG
                {
                    id = 2,
                    MaNguoiDung = "ND002",
                    TenNguoiDung = "Người Dùng 2",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "user",
                    MatKhau = "password",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
            }.AsQueryable();

            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Provider).Returns(nguoiDung.Provider);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Expression).Returns(nguoiDung.Expression);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.ElementType).Returns(nguoiDung.ElementType);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.GetEnumerator()).Returns(nguoiDung.GetEnumerator());

            dbContextMock.Setup(m => m.NGUOIDUNGs).Returns(dbSetMock.Object);

            // Act
            bool result = dalLogin.Login(username, password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ExistingUsername_ReturnsTrue()
        {
            // Arrange
            string username = "testuser";

            var nguoiDung = new List<NGUOIDUNG>
            {
                new NGUOIDUNG
                {
                    id = 1,
                    MaNguoiDung = "ND001",
                    TenNguoiDung = "Người Dùng 1",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "testuser",
                    MatKhau = "testpassword",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
                new NGUOIDUNG
                {
                    id = 2,
                    MaNguoiDung = "ND002",
                    TenNguoiDung = "Người Dùng 2",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "user",
                    MatKhau = "password",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
            }.AsQueryable();

            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Provider).Returns(nguoiDung.Provider);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Expression).Returns(nguoiDung.Expression);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.ElementType).Returns(nguoiDung.ElementType);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.GetEnumerator()).Returns(nguoiDung.GetEnumerator());

            dbContextMock.Setup(m => m.NGUOIDUNGs).Returns(dbSetMock.Object);

            // Act
            bool result = dalLogin.Check(username);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_NonExistingUsername_ReturnsFalse()
        {
            // Arrange
            string username = "nonexistinguser";

            var nguoiDung = new List<NGUOIDUNG>
            {
                new NGUOIDUNG
                {
                    id = 1,
                    MaNguoiDung = "ND001",
                    TenNguoiDung = "Người Dùng 1",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "testuser",
                    MatKhau = "testpassword",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
                new NGUOIDUNG
                {
                    id = 2,
                    MaNguoiDung = "ND002",
                    TenNguoiDung = "Người Dùng 2",
                    NgaySinh = new DateTime(2023, 1, 1),
                    ChucVu = "Nhân viên",
                    TenDangNhap = "user",
                    MatKhau = "password",
                    idNhomNguoiDung = 1,
                    SoDT = "0123456789",
                    AnhDaiDien = "avatar1.jpg",
                    DiaChi = "Địa chỉ 1"
                },
            }.AsQueryable();

            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Provider).Returns(nguoiDung.Provider);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Expression).Returns(nguoiDung.Expression);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.ElementType).Returns(nguoiDung.ElementType);
            dbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.GetEnumerator()).Returns(nguoiDung.GetEnumerator());

            dbContextMock.Setup(m => m.NGUOIDUNGs).Returns(dbSetMock.Object);

            // Act
            bool result = dalLogin.Check(username);

            // Assert
            Assert.IsFalse(result);
        }
    }
}