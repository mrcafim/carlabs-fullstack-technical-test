using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Infra.Data.Repository
{
	public class MenuRepository : IMenuRepository
	{
		private readonly DataContext _context;

		public MenuRepository(DataContext context)
		{
			_context = context;
		}

		public Menu GetById(Guid id)
		{
			return _context
				.Menus
				.Include(x => x.Products)
				.FirstOrDefault(x => x.Id == id);
		}
		public Menu GetByMealType(MealType type)
		{
			return _context
				.Menus
				.Include(x => x.Products)
				.FirstOrDefault(x => x.Type == type);
		}
		public List<Menu> Get()
		{
			return _context.Menus.Include(x => x.Products).ToList();
		}

		public void Dispose()
		{
			_context.Dispose();
		}

	}
}
