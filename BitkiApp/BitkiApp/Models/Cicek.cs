using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBotanikApp.Models
{
    public class Cicek
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string SliderResmi { get; set; }
        public bool HaftaninCicegiMi { get; set; }
        public bool EnCokSatanMi { get; set; }

    }
}
