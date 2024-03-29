﻿using E_commerce.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.DAL.IRepository
{
    public interface IImageRepository
    {
        public Task UploadImage(Image image);
        public Task<IEnumerable<Image>> GetAllImagesByProductId(int productId);
        public Task DeleteImage(Image image);
    }
}
