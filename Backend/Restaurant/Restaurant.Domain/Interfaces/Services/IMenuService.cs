using Flunt.Notifications;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Models.Product;
using System;
using System.Collections.Generic;

namespace Restaurant.Domain.Interfaces.Services
{
    public interface IMenuService
    {
        Menu Get(Guid id);
        Menu GetByMealType(MealType type);
        List<Menu> Get();
    }

}
