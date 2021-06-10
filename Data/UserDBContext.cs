using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid_App_2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace Covid_App_2._0.Data
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }
        public DbSet<UserDb> Users { get; set; }
    }
}
