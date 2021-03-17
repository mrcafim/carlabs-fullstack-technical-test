using Microsoft.Extensions.DependencyInjection;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Infra.Data.Repository;
using Restaurant.Service;

namespace Restaurant.Infra.IoC
{
	public static class ProductDependencyInjector
	{
		public static void Register(IServiceCollection services)
		{
			// Services
			services.AddScoped<IProductService, ProductService>();

			// Repositories
			services.AddScoped<IProductRepository, ProductRepository>();
		}
	}
}