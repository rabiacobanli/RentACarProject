﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
       // CarName, BrandName, ColorName, DailyPrice.
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int BrandName { get; set; }
        public decimal DailyPrice { get; set; }
        public string ColorName { get; set; }
    }
}
