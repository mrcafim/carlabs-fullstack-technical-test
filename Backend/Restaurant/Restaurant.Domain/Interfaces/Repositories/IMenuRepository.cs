using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Restaurant.Domain.Interfaces.Repositories
{
	public interface IMenuRepository : IDisposable
	{
		Menu GetById(Guid id);
		Menu GetByMealType(MealType type);
		List<Menu> Get();
	}
}