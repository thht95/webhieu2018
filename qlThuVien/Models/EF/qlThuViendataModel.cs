namespace qlThuVien.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class qlThuViendataModel : DbContext
    {
        public qlThuViendataModel()
            : base("name=qlThuViendataModel")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<Muon_Tra> Muon_Tra { get; set; }
        public virtual DbSet<NguoiMuon> NguoiMuons { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
