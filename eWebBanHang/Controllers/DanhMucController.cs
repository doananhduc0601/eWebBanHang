using eWebBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eWebBanHang.Controllers
{
    public class DanhMucController : Controller
    {
        private ShopBanHangEntities db = new ShopBanHangEntities();
        // GET: DanhMuc
        public ActionResult DanhmucPartial()
        {

            var danhmuc = db.Hangsanxuats.ToList();
            return PartialView(danhmuc);
        }
    }
}