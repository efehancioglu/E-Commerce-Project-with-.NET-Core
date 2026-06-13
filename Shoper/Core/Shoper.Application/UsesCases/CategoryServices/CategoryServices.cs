using Shoper.Application.Dtos.CategoryDtos;
using Shoper.Application.Interfaces;
using Shoper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.Application.UsesCases.CategoryServices
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IRepository<Category> _repository;

        public CategoryServices(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public Task CreateCategoryAsync(CreateCategoryDto model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultCategoryDto> GetByIdCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto model)
        {
            throw new NotImplementedException();
        }
    }
}
