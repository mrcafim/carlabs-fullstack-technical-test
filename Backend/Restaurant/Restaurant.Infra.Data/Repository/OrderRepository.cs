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
	public class OrderRepository : IOrderRepository
	{
		private readonly DataContext _context;

		public OrderRepository(DataContext context)
		{
			_context = context;
		}

		public List<Order> Get()
		{
			return _context.Orders.Include(x => x.Product).ToList();
		}

		public Order GetById(Guid id)
		{
			return _context
				.Orders
				.Include(x => x.Product)
				.FirstOrDefault(x => x.Id == id);
		}
		public List<Order> GetByTable(int table)
		{
			return _context
				.Orders
				.Include(x => x.Product)
				.Where(x => x.TableNumber == table)
				.ToList();
		}

		public Order Add(Order order)
		{
			_context.Orders.Add(order);
			_context.SaveChanges();

			return order;
		}

		public void Dispose()
		{
			_context.Dispose();
		}

	}
}
