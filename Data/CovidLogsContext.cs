using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid_App_2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace Covid_App_2._0.Data
{
    public class CovidLogsContext : DbContext
    {
        public CovidLogsContext(DbContextOptions<CovidLogsContext> options) : base(options)
        {
                //Testing
        }
        public DbSet<CovidLogs> Logs{ get; set; }
    }
}
