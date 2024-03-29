using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBotanikApp.Models
{
    public class AnaSayfaViewModel
    {
        public List<Kategori> Kategoriler { get; set; }
        public List<Cicek> HaftaninUrunuMu { get; set; }
        public List<Cicek> EnCokSatanMi { get; set; }
    }
}
