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

    public partial class CHITIETBCDOANHTHU
    {
        public int idMaBCDoanhThu { get; set; }
        public System.DateTime NgayKham { get; set; }
        public float DoanhThu { get; set; }
        public float TyLe { get; set; }

        public virtual BC_DOANHTHU BC_DOANHTHU { get; set; }
    }
}