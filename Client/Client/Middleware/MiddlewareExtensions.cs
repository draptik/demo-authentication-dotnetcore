﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace Client.Middleware
{
	public static class MiddlewareExtensions
    {
		public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
		{
			services.AddSwaggerGen(cfg =>
			{
				cfg.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "Client API",
					Version = "v1",
					Description = "Example API of a B2B Shop",
				});

				//cfg.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				//{
				//	In = ParameterLocation.Header,
				//	Description = "JSON Web Token to access resources. Example: Bearer {token}",
				//	Name = "Authorization",
				//	Type = SecuritySchemeType.ApiKey
				//});

				//cfg.AddSecurityRequirement(new OpenApiSecurityRequirement
				//{
				//	{
				//		new OpenApiSecurityScheme
				//		{
				//			Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
				//		},
				//		new [] { string.Empty }
				//	}
				//});

				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				cfg.IncludeXmlComments(xmlPath);
			});

			return services;
		}

		public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder app)
		{
			app.UseSwagger().UseSwaggerUI(options =>
			{
				options.SwaggerEndpoint("/swagger/v1/swagger.json", "Client API");
				options.DocumentTitle = "Client API";
			});

			return app;
		}

	}
}
