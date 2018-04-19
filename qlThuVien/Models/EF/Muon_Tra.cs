namespace qlThuVien.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Muon_Tra
    {
        [Key]
        public int PK_muontra { get; set; }

        [StringLength(50)]
        [Display(Name = "Mã sách")]
        public string maSach { get; set; }

        [StringLength(50)]
        [Display(Name = "Mã độc giả")]
        public string maDocGia { get; set; }

        public int? soLuong { get; set; }

        public DateTime? ngayMuon { get; set; }

        public DateTime? ngayHenTra { get; set; }

        public DateTime? ngayTra { get; set; }

        public virtual NguoiMuon NguoiMuon { get; set; }
    }
}
