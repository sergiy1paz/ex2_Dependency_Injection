using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Services;

namespace ex2_Dependency_Injection.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddArticleServices(this IServiceCollection services)
        {
            services.AddScoped<IArticleInfoService, ArticleInfoService>();
            services.AddTransient<IArticleContentService, ArticleContentService>();
            services.AddScoped<ICheckArticleService, CheckArticleService>();
            services.AddScoped<IPublishArticleService, PublishArticleService>();
            services.AddScoped<IArticleProcessService, ArticleProcessService>();

            return services;
        }
    }
}
