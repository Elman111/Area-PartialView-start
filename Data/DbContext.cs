﻿namespace HomeworkMigration.Data
{
    public class DbContext
    {
        private DbContextOptions<AppDbContext> options;

        public DbContext(DbContextOptions<AppDbContext> options)
        {
            this.options = options;
        }
    }
}