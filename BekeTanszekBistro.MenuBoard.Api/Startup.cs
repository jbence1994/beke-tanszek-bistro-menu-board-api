using AutoMapper;
using BekeTanszekBistro.MenuBoard.Api.Core;
using BekeTanszekBistro.MenuBoard.Api.Helpers;
using BekeTanszekBistro.MenuBoard.Api.Core.Repositories;
using BekeTanszekBistro.MenuBoard.Api.Persistence;
using BekeTanszekBistro.MenuBoard.Api.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BekeTanszekBistro.MenuBoard.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(Constants.DefaultCorsPolicy, builder =>
                {
                    builder.AllowAnyHeader();
                    builder.AllowAnyOrigin();
                    builder.WithMethods("POST", "GET", "DELETE", "PUT");
                });
            });

            services.AddControllers();

            services.AddAutoMapper();

            services.AddScoped<IDailyMenuRepository, DailyMenuRepository>();
            services.AddScoped<IMealRepository, MealRepository>();
            services.AddScoped<ITypeRepository, TypeRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySQL(_configuration.GetConnectionString("Default")));

            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "BekeTanszekBistro.MenuBoard.Api", Version = "v1"}));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();

                app.UseSwaggerUI(c =>
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BekeTanszekBistro.MenuBoard.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(Constants.DefaultCorsPolicy);

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        }
    }
}
