//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            this.CTPhanQuyens = new HashSet<CTPhanQuyen>();
        }
    
        public string IDquyen { get; set; }
        public string LoaiQuyen { get; set; }
        public Nullable<short> TrangThai { get; set; }
    
        public virtual ICollection<CTPhanQuyen> CTPhanQuyens { get; set; }
    }
}
