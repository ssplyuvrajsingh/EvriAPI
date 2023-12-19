using Rex.RIMS.EvriAPI.Services.IService;

namespace Rex.RIMS.EvriAPI.Services
{
	public static class ServiceExtension
	{
		public static void AddServices(this IServiceCollection services) =>
			services.AddServices(typeof(IScoppedService), ServiceLifetime.Scoped);

		internal static IServiceCollection AddServices(this IServiceCollection services, Type interfaceType, ServiceLifetime lifetime)
		{
			var interfaceTypes =
				AppDomain.CurrentDomain.GetAssemblies()
					.SelectMany(s => s.GetTypes())
					.Where(t => interfaceType.IsAssignableFrom(t)
								&& t.IsClass && !t.IsAbstract)
					.Select(t => new
					{
						Service = t.GetInterfaces().FirstOrDefault(),
						Implementation = t
					})
					.Where(t => t.Service is not null
								&& interfaceType.IsAssignableFrom(t.Service));

			foreach (var type in interfaceTypes)
			{
				services.AddService(type.Service!, type.Implementation, lifetime);
			}

			return services;
		}

		internal static IServiceCollection AddService(this IServiceCollection services, Type serviceType, Type implementationType, ServiceLifetime lifetime) =>
		   lifetime switch
		   {
			   ServiceLifetime.Scoped => services.AddScoped(serviceType, implementationType),
			   _ => throw new ArgumentException("Invalid lifeTime", nameof(lifetime))
		   };

	}
}
