using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using qlThuVien.Models.EF;

namespace qlThuVien.Controllers
{
    public class MuontraSachController : Controller
    {
        qlThuViendataModel db = new qlThuViendataModel();

        // GET: Tacgia
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(db.Muon_Tra.ToList().OrderBy(n => n.maDocGia).ToPagedList(pageNumber, pageSize));
        }

        // Thêm mới
        [HttpGet]//yêu cầu dữ liệu từ 1 nguồn nhất định (có thể được lưu lại)
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]//Gửi dữ liệu để xử lý tới một nguồn nhất định (không bao giờ được lưu trữ)
        public ActionResult Them(Muon_Tra muon_tra)
        {
            db.Muon_Tra.Add(muon_tra);
            db.SaveChanges();
            return View();
        }

        //Chỉnh sửa
        [HttpGet]
        public ActionResult Sua(string maDocgia, string maSach)
        {
            // lấy ra đối tượng theo mã sách
            Muon_Tra muontra = db.Muon_Tra.SingleOrDefault(n => n.maSach == maSach && n.maDocGia == maDocgia);

            if (muontra == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(muontra);
        }
        [HttpPost]
        public ActionResult Sua(Muon_Tra muon_tra)
        {
            db.Entry(muon_tra).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // Xóa
        public ActionResult Xoa(int pk_muontra)
        {
            //lấy đối tượng theo mã sách
            Muon_Tra muontra = db.Muon_Tra.Where(n => n.PK_muontra == pk_muontra).FirstOrDefault();

            if (muontra == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(muontra);
        }

        [HttpPost, ActionName("Xoa")]
        public ActionResult xacNhanXoa()
        {

            var z = Convert.ToInt32( Request.Params["PK_muontra"]);
            //lấy đối tượng theo mã sách
            Muon_Tra sach = db.Muon_Tra.SingleOrDefault(n => n.PK_muontra == z);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            db.Muon_Tra.Remove(sach);
            db.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}