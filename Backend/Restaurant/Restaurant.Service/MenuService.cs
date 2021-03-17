using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Product;

namespace Restaurant.Service
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _repository;

        public MenuService(IMenuRepository repository)
        {
            _repository = repository;
        }

        public Menu Get(Guid id)
        {
            return _repository.GetById(id);
        }
        public Menu GetByMealType(MealType type)
        {
            return _repository.GetByMealType(type);
        }
        public List<Menu> Get()
        {
            return _repository.Get();
        }
    }
}
