using Microsoft.EntityFrameworkCore;
using WebAPP_Template.Backend.API.Extensions;
using WebAPP_Template.Backend.Application.Extensions;
using WebAPP_Template.Backend.Application.Options;
using WebAPP_Template.Backend.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
	.AddWebServices(builder.Configuration)
	.AddApplicationServices(builder.Configuration);

builder.Services.AddDbContext<MyContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("MyContext"));
});

//builder.Services
//.AddScoped<IRepository, Repository>(); // Add repositories here like this

var corsOptions = new CorsOption();
builder.Configuration.GetSection("Cors").Bind(corsOptions);

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "CORS_POLICY",
	   builder =>
	   {
		   builder.WithOrigins(corsOptions.Origins.ToArray())
							   .AllowAnyHeader()
							   .AllowAnyMethod()
							   .AllowCredentials();
	   });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{

app.UseSwagger();
app.UseSwaggerUI();

app.UseExceptionHandler("/Error");
// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("CORS_POLICY");
//app.UseAuthorization();
app.MapControllers();
//app.MapRazorPages();

app.Run();
