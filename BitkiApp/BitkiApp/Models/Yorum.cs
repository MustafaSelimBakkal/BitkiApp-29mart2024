﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBotanikApp.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string YorumAciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}
