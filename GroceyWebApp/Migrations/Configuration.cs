namespace GroceyWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    
    using GroceyWebApp.Models;
    

    internal sealed class Configuration : DbMigrationsConfiguration<GroceyWebApp.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext
        }

        protected override void Seed(GroceyWebApp.Models.DataContext context)
        {
        //    var MasterList = new List<MasterListModel>
        //    {
        //        new MasterListModel
        //        {
        //            ListId = Guid.NewGuid(),
        //            ListName = "List No.1",
        //            CreatedDate = DateTime.Now,
        //            Details = new List<DetailListModel>
        //            {
        //                new DetailListModel
        //                {
        //                    DetailId = Guid.NewGuid(),
        //                    DetailName = "Susu Bendera 00",
        //                    DetailQty = 2,
        //                    DetailsUom = "Pack",
        //                },
        //                new DetailListModel
        //                {
        //                    DetailId = Guid.NewGuid(),
        //                    DetailName = "Gula Pasir 00",
        //                    DetailQty = 6,
        //                    DetailsUom = "Kg",
        //                },
        //                new DetailListModel
        //                {
        //                    DetailId = Guid.NewGuid(),
        //                    DetailName = "Permen Polo 00",
        //                    DetailQty = 2,
        //                    DetailsUom = "Pack",
        //                },
        //            }
        //        },
        //        new MasterListModel
        //        {
        //            ListId = Guid.NewGuid(),
        //            ListName = "List No.2",
        //            CreatedDate = DateTime.Now,
        //        },
        //        new MasterListModel
        //        {
        //            ListId = Guid.NewGuid(),
        //            ListName = "List No.3",
        //            CreatedDate = DateTime.Now,
        //        },
        //        new MasterListModel
        //        {
        //            ListId = Guid.NewGuid(),
        //            ListName = "List No.4",
        //            CreatedDate = DateTime.Now,
        //        },
        //        new MasterListModel
        //        {
        //            ListId = Guid.NewGuid(),
        //            ListName = "List No.5",
        //            CreatedDate = DateTime.Now,
        //        },
        //    };
        //    MasterList.ForEach(m => context.masterList.Add(m));
        //    context.SaveChanges();
        }
    }
}
