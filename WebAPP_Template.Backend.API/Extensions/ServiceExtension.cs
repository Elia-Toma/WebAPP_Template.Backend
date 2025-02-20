using Microsoft.OpenApi.Models;

namespace WebAPP_Template.Backend.API.Extensions
{
	public static class ServiceExtension
	{
		public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllers();

			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "WebAPP_Template",
					Version = "v1"
				});
			});

			return services;
		}
	}
}
