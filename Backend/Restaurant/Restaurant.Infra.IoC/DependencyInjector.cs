using Microsoft.Extensions.DependencyInjection;

namespace Restaurant.Infra.IoC
{
	public static class DependencyInjector
	{
		public static void Register(IServiceCollection services)
		{
			// Modules
			RegisterModules(services);
		}

		private static void RegisterModules(IServiceCollection services)
		{
			ProductDependencyInjector.Register(services);
			MenuDependencyInjector.Register(services);
			OrderDependencyInjector.Register(services);
		}
	}
}