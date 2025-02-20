using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPP_Template.Backend.Application.Extensions
{
	public static class ServiceExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
		{
			//services
				//.AddScoped<IService, Service>(); // Add services here like this

			return services;
		}
	}
}
