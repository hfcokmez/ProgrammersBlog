using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.DataAccess.Abstract;
using ProgrammersBlog.DataAccess.Concrete;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleManager>()
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<ICategoryService, CategoryManager>()
                .AddScoped<ICommentService, CommentManager>()
                .AddScoped<IRoleService, RoleManager>()
                .AddScoped<IUserService, UserManager>();
            return services;
        }
    }
}
