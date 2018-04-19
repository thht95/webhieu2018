using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using qlThuVien.Models.EF;

namespace qlThuVien.Controllers
{
    public class NguoimuonController : Controller
    {
        qlThuViendataModel db = new qlThuViendataModel();

        // GET: Tacgia
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(db.NguoiMuons.ToList().OrderBy(n => n.maDocGia).ToPagedList(pageNumber, pageSize));
        }
    }
}