using System;
using System.Collections.Generic;
using System.Linq;
using DirectoryApp.Entity;
using DirectoryApp.Entity.ModelDb;
using Microsoft.EntityFrameworkCore;

namespace DirectoryApp.DAL
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {

        }

        public ModelContext(DbContextOptions<ModelContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Client> Client { get; set; }

        public virtual DbSet<ContactInfo> ContactInfo { get; set; }
        public virtual DbSet<InfoType> InfoType { get; set; }

         


    }
}
