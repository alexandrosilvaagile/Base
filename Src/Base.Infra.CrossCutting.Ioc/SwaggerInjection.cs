using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Base.Infra.CrossCutting.Ioc
{
    public static class SwaggerInjection
    {
        public static void AddSwagger(this IServiceCollection services, Assembly apiAssembly)
        {
            var apiName = apiAssembly.GetName().Name;

            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Version = "v1",
                        Title = apiName,
                        Description = apiName,
                        Contact = new OpenApiContact
                        {
                            Name = "Grupo Herval",
                            Email = string.Empty
                        },
                        License = new OpenApiLicense
                        {
                            Name = "Use under LICX"
                        }
                    });

                    var xmlFile = $"{apiAssembly.GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    options.IncludeXmlComments(xmlPath);

                    var bearerTokenSecurityScheme = new OpenApiSecurityScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                        Name = "Authorization",
                        Scheme = "oauth2",
                        In = ParameterLocation.Header
                    };

                    options.AddSecurityDefinition("Bearer", bearerTokenSecurityScheme);
                    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                    {
                        {
                            new OpenApiSecurityScheme {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            }, new List<string>()
                        }
                    });

                }
            );
        }

        public static void AddSwaggerConfiguration(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Base.Api v1"));
        }
    }
}
