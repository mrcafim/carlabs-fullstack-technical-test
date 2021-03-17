using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Restaurant.Domain.Interfaces.Repositories
{
	public interface IOrderRepository : IDisposable
	{
		List<Order> Get();
		Order GetById(Guid id);
		List<Order> GetByTable(int table);
		Order Add(Order id);
	}
}