namespace qlThuVien.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [Key]
        [StringLength(50)]
        [Display(Name = "Mã loại sách")]
        public string maSach { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên sách")]
        public string tenSach { get; set; }

        public DateTime? namXuatBan { get; set; }

        [Display(Name = "")]
        public int? soLuong { get; set; }

        [StringLength(50)]
        [Display(Name = "Mã loại sách")]
        public string maLoaiSach { get; set; }

        [StringLength(50)]
        [Display(Name = "Mã tác giả")]
        public string maTacGia { get; set; }

        public virtual LoaiSach LoaiSach { get; set; }

        public virtual TacGia TacGia { get; set; }
    }
}
