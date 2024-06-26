﻿using BetaTesters.Core.Contracts;
using BetaTesters.Core.Services;
using BetaTesters.Data;
using BetaTesters.Infrastructure.Data.Common;
using BetaTesters.Infrastructure.Data.Models;
using BetaTesters.PaymentIntegration.Stripe;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICandidateApplicationService, CandidateApplicationService>();
            services.AddScoped<IBetaProgramService, BetaProgramService>();
            services.AddScoped<IApplicationUserService, ApplicationUserService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITransactionService, TransactionService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<BetaTestersDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<BetaTestersDbContext>();

            return services;
        }

        public static IServiceCollection AddPaymentIntegration(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<StripeSettings>(config.GetSection("StripeSettings"));

            return services;
        }
    }
}
