using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace GroceyWebApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("grooceyContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer
               (new MigrateDatabaseToLatestVersion<DataContext, GroceyWebApp.Migrations.Configuration>("grooceyContext"));
        }

        public DbSet<MasterListModel> masterList { get; set; }
        public DbSet<DetailListModel> detailList { get; set; }
        public DbSet<UserModel> user { get; set; }
    }
}