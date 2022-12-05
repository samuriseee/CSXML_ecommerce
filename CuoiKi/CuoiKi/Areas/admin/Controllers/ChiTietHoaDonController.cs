using CuoiKi.Areas.admin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuoiKi.Areas.admin.Controllers
{
    public class ChiTietHoaDonController : Controller
    {
        // GET: admin/ChiTietHoaDon
        public ActionResult Index()
        {
            return View();
        }

        
    }
}