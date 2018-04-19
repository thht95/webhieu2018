namespace qlThuVien.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login")]
    public partial class login
    {
        [StringLength(50)]
        [Display(Name = "ID")]
        public string ID { get; set; }

        [StringLength(50)]
        [Display(Name = "name")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "pass")]
        public string PassWord { get; set; }
    }
}
