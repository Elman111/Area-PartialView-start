using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeworkMigration.ViewModels;

namespace HomeworkMigration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ValentineContent> ValentineContents { get; set; }
    }
}
