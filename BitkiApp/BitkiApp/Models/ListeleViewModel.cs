using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBotanikApp.Models
{
    public class ListeleViewModel
    {
        public List<Cicek> Cicekler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public Kategori Kategori { get; set; }
    }
}
