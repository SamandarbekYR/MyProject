using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess.AppDbContext;
using System;
using System.Runtime.CompilerServices;

namespace MyProject.WebApi.Configuration
{
    public static class DataAccessConfigurations
    {
        public static void ConfigureDataAccess (this WebApplicationBuilder builder1)
        {
            string connection = builder1.Configuration.GetConnectionString("DatabaseConnectionString")!;
            builder1.Services.AddDbContext<AppDb>(options =>
            options.UseNpgsql(connection));
        }
    }
}
