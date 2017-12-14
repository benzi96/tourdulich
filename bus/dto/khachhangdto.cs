﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
    public class khachhangdto
    {
        public int id { get; set; }
        public string socmnd_tenkh { get; set; }
        public khachhangdto(khachhang kh)
        {
            id = kh.id;
            socmnd_tenkh = kh.socmnd + " -- " + kh.tenkhachhang;
        }
    }
}
