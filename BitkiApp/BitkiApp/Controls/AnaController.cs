using BizimBotanikApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BizimBotanikApp.Controls
{
    public class AnaController : Controller
    {
        public IActionResult Index()
        {
            AnaSayfaViewModel model = new AnaSayfaViewModel
            {
                Kategoriler = Fabrika.Kategoriler,
                HaftaninUrunuMu = Fabrika.Cicekler.Where(c => c.HaftaninCicegiMi = true).ToList(),
                EnCokSatanMi = Fabrika.Cicekler.Where(c=> c.EnCokSatanMi = true).ToList()
            };
            
            return View(model);
        }

        public IActionResult Listele(int? id)
        {
            ListeleViewModel model = new ListeleViewModel
            {
                Cicekler = Fabrika.Cicekler.Where(c => c.KategoriId == id).ToList(),
                Kategoriler = Fabrika.Kategoriler,
                Kategori = Fabrika.Kategoriler.FirstOrDefault(k => k.Id == id)
            };

            var kategori = Fabrika.Kategoriler.FirstOrDefault(k => k.Id == id);
            ViewBag.kategoriId = kategori.Id;

            return View(model);
        }

        public IActionResult Hakkinda(int? id)
        {
            var cicek = Fabrika.Cicekler.FirstOrDefault(c => c.Id == id);
            if (cicek != null)
            {
                return View(cicek);
            }

            return RedirectToAction("Eror");
            
        }
        public IActionResult Eror()
        {
            return View();
        }

    }
}
