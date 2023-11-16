﻿using E_commerce.Models;
using E_commerce.Models.DTO_s.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.BLL.IService
{
    public interface IImageService
    {
        public Task<ApiResponse> UploadImage(ImageUploadRequest imageUploadRequest);
    }
}
