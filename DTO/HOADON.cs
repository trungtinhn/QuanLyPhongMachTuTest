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

    public partial class HOADON
    {
        public int SoHoaDon { get; set; }
        public Nullable<int> SoPhieuKhamBenh { get; set; }
        public int TienKham { get; set; }
        public int TienThuoc { get; set; }

        public int idBenhNhan { get; set; }
        public string TrangThai { get; set; }

        public virtual PHIEUKHAMBENH PHIEUKHAMBENH { get; set; }
        public virtual BENHNHAN BENHNHAN { get; set; }
    }
}