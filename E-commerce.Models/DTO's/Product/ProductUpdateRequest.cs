﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Models.DTO_s.Product
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
