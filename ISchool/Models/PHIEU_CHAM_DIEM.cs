//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISchool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEU_CHAM_DIEM
    {
        public int SoPCD { get; set; }
        public int SoPGDT { get; set; }
        public Nullable<System.DateTime> NgayCham { get; set; }
        public string Vaitro_GV { get; set; }
        public Nullable<double> Diem_Detai { get; set; }
        public int MAGV { get; set; }
    
        public virtual PhieuGiaoDT PhieuGiaoDT { get; set; }
        public virtual GIANGVIEN GIANGVIEN { get; set; }
    }
}
