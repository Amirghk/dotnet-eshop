﻿using App.Domain.Core.Product.Contacts.AppServices;
using App.Domain.Core.Product.Contacts.Services;
using App.Domain.Core.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Product
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _service;
        public CategoryAppService(ICategoryService categoryService)
        {
            _service = categoryService;
        }
        public void Delete(int id)
        {
            _service.EnsureExists(id);
            _service.Delete(id);
        }

        public async Task<CategoryDto> Get(int id)
        {
            return await _service.Get(id);
        }

        public async Task<CategoryDto> Get(string name)
        {
            return await _service.Get(name);
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            return await _service.GetAll();
        }

        public async Task Set(CategoryDto dto)
        {
            _service.EnsureExists(dto.Id);
            await _service.Set(dto);
        }

        public async Task Update(CategoryDto dto)
        {
            _service.EnsureExists(dto.Id);
            await _service.Update(dto);
        }
    }
}