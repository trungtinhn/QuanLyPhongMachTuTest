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

    public partial class CT_PHIEUKHAMBENH
    {
        public int SoPhieuKhamBenh { get; set; }
        public int idMaThuoc { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
        public int SoLuong { get; set; }
        public Nullable<int> idMaCachDung { get; set; }

        public virtual CACHDUNG CACHDUNG { get; set; }
        public virtual THUOC THUOC { get; set; }
        public virtual PHIEUKHAMBENH PHIEUKHAMBENH { get; set; }
    }
}