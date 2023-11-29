using Microsoft.EntityFrameworkCore;
using MyProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.AppDbContext
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options)
            : base(options)
        {

        }
        DbSet<User> Users { get; set; }
    }
}
