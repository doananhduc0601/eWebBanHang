using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eWebBanHang.Models;

namespace eWebBanHang.Controllers
{
    public class SanphamsController : Controller
    {
        private ShopBanHangEntities db = new ShopBanHangEntities();

        // GET: Sanphams
        public ActionResult Index()
        {
            var sanphams = db.Sanphams.Include(s => s.Hangsanxuat);
            return View(sanphams.ToList());
        }
        public ActionResult dtiphonepartial()
        {
            var ip = db.Sanphams.Where(n => n.Mahang == 1).Take(4).ToList();
            return PartialView(ip);
        }
        public ActionResult dtsamsungpartial()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 2).Take(4).ToList();
            return PartialView(ss);
        }
        public ActionResult dtxiaomipartial()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            return PartialView(mi);
        }
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp = 0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n => n.Masp == Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }
}

