﻿using E_commerce.Models;
using E_commerce.Models.DTO_s.User;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_BLL.IService
{
    public interface IUserService
    {
        public Task<ApiResponse> UserRegister(UserRegisterRequest userRegisterReq);
        public Task<ApiResponse> GetUserById(string id);
        public Task<ApiResponse> DeleteUserById(string id);
        public Task<ApiResponse> UpdateUserPassword(UserUpdatePasswordRequest userUpdateReq);
        public Task<ApiLoginResponse> UserLogin(UserLoginRequest userLoginReq);
        public Task<ApiResponse> GetUserByEmail(string email);
    }
}
