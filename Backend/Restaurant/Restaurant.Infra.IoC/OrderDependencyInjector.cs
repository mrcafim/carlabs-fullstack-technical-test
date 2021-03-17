using Microsoft.Extensions.DependencyInjection;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Infra.Data.Repository;
using Restaurant.Service;

namespace Restaurant.Infra.IoC
{
	public static class OrderDependencyInjector
	{
		public static void Register(IServiceCollection services)
		{
			// Services
			services.AddScoped<IOrderService, OrderService>();

			// Repositories
			services.AddScoped<IOrderRepository, OrderRepository>();
		}
	}
}