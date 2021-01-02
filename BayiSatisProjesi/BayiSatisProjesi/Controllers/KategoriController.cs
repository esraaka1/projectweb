using BayiSatisProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BayiSatisProjesi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() { Id = 1, KategoriAdi = "Kamyon"},
                new Kategori() { Id = 2, KategoriAdi = "Tır"},
                new Kategori() { Id = 3, KategoriAdi = "Traktör"}
            };
            return PartialView("KategoriMenu", kategoriler);
    }
  }
}