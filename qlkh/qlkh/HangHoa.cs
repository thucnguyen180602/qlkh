//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlkh
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            this.HHTrongKhoes = new HashSet<HHTrongKho>();
        }
    
        public string Barcode { get; set; }
        public string TenHH { get; set; }
        public Nullable<int> DonViTinh { get; set; }
        public Nullable<int> XuatXu { get; set; }
        public string TenTat { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<bool> Disabled { get; set; }
        public Nullable<int> Created_By { get; set; }
    
        public virtual DonViTinh DonViTinh1 { get; set; }
        public virtual QuocGia QuocGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HHTrongKho> HHTrongKhoes { get; set; }
    }
}
