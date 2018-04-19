using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qlThuVien.Models;
using PagedList.Mvc;
using PagedList;
using qlThuVien.Models.EF;

namespace qlThuVien.Controllers
{
    public class timKiemController : Controller
    {
        qlThuViendataModel db = new qlThuViendataModel();
        [HttpPost]
        // GET: timKiem
        public ActionResult ketQuaTimKiem(FormCollection f, int? paged)
        {
            string sTuKhoa = f["txtTimKiem"].ToString();
            List<Sach> lstKQTK = db.Saches.Where(n => n.tenSach.Contains(sTuKhoa)).ToList();

            // Phân trang
            int pagedNumber = (paged ?? 1);
            int pagedSize = 8;

            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy nội dung yêu cầu";
                return View(db.Saches.OrderBy(n => n.tenSach).ToPagedList(pagedNumber, pagedSize));
            }

            return View(lstKQTK.OrderBy(n => n.tenSach).ToPagedList(pagedNumber, pagedSize));
        }
    }
}