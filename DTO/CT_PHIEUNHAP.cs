﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;

    public partial class CT_PHIEUNHAP
    {
        public int SoPhieuNhapThuoc { get; set; }
        public int idMaThuoc { get; set; }
        public int DonGiaNhap { get; set; }
        public int ThanhTien { get; set; }
        public int SoLuongNhap { get; set; }

        public virtual THUOC THUOC { get; set; }
        public virtual PHIEUNHAPTHUOC PHIEUNHAPTHUOC { get; set; }
    }
}