using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBotanikApp.Models
{
    public class Fabrika
    {
        public static List<Cicek> Cicekler { get; set; } = new List<Cicek>
        {
            new Cicek {Id=1,
                KategoriId=1,
                Ad="Sarı Yediveren",
                Aciklama="En aşk dolu güllerden birisidir",
                Resim="Sari_Yediveren.jpeg",
                HaftaninCicegiMi=false,
                SliderResmi="Sari_Yediveren.jpeg",
                EnCokSatanMi = true
            },

            new Cicek
            {
                Id=2,
                KategoriId=2,
                Ad="Lotus Çiçeği",
                Resim="Lotus.jpeg",
                HaftaninCicegiMi=false,
                SliderResmi="Lotus.jpeg",
                Aciklama="Çok tatlı su kenarında olan bir çiçek",
                EnCokSatanMi = false
            },
            new Cicek
            {
                Id=3,
                KategoriId=3,
                Ad="Gül",
                Resim="Gul.jpg",
                HaftaninCicegiMi=false,
                SliderResmi="Gul.jpg",
                Aciklama="Çok güzel aşkın temsilcisi",
                EnCokSatanMi = false
            },
            new Cicek
            {
                Id=4,
                KategoriId=3,
                Ad="Ay Çiçeği",
                Resim="Ay_Cicegi.jpg",
                HaftaninCicegiMi=false,
                SliderResmi="Ay_Cicegi.jpg",
                Aciklama="Sarı çiççek",
                EnCokSatanMi = false
            },
            new Cicek
            {
                Id = 5,
                KategoriId = 3,
                Ad="Mavi Anemon Çiçeği",
                Resim="Mavi_Anemon.jpg",
                HaftaninCicegiMi=false,
                SliderResmi="Mavi_Anemon.jpg",
                Aciklama="Sarı çiççek",
                EnCokSatanMi = false
            },
            new Cicek
            {
                Id = 6,
                KategoriId = 3,
                Ad="Papatya Çiçeği",
                Resim="Papatya.jpg",
                Aciklama="Papatya güzeldir",
                EnCokSatanMi=true,
                HaftaninCicegiMi=true,
                SliderResmi="Papatya.jpg"
            }
        };

        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>
        {
            new Kategori{Id=1,Ad="Yasaklı Bitkiler"},
            new Kategori{Id=2,Ad="Şifalı Bitkiler"},
            new Kategori{Id=3,Ad="Yabancı Bitkiler"},
            new Kategori{Id=4, Ad="Deneme Hübele"}
        };

        public List<Yorum> Yorumlar { get; set; }
    }
}
