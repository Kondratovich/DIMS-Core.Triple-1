﻿using DIMS_Core.Mailer.Interfaces;
using DIMS_Core.Mailer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DIMS_Core.Mailer.Extensions
{
    public static class MiddlewareServiceExtensions
    {
        public static IServiceCollection AddMailerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ISender, Sender>();

            return services;
        }
    }
}