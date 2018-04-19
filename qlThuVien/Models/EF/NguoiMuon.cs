namespace qlThuVien.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiMuon")]
    public partial class NguoiMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiMuon()
        {
            Muon_Tra = new HashSet<Muon_Tra>();
        }

        [Key]
        [StringLength(50)]
        [Display(Name = "Mã độc giả")]
        public string maDocGia { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên độc giả")]
        public string tenDocGia { get; set; }

        public bool? gioiTinh { get; set; }

        public int? soDT { get; set; }

        [StringLength(250)]
        public string diaChi { get; set; }

        public DateTime? ngayMuon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muon_Tra> Muon_Tra { get; set; }
    }
}
