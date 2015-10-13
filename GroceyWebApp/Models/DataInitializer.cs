using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace GroceyWebApp.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var MasterList = new List<MasterListModel>
            {
                new MasterListModel
                {
                    ListId = Guid.NewGuid(),
                    ListName = "List No.1",
                    CreatedDate = DateTime.Now,
                },
                new MasterListModel
                {
                    ListId = Guid.NewGuid(),
                    ListName = "List No.2",
                    CreatedDate = DateTime.Now,
                },
                new MasterListModel
                {
                    ListId = Guid.NewGuid(),
                    ListName = "List No.3",
                    CreatedDate = DateTime.Now,
                },
                new MasterListModel
                {
                    ListId = Guid.NewGuid(),
                    ListName = "List No.4",
                    CreatedDate = DateTime.Now,
                },
                new MasterListModel
                {
                    ListId = Guid.NewGuid(),
                    ListName = "List No.5",
                    CreatedDate = DateTime.Now,
                },
            };
            MasterList.ForEach(m => context.masterList.Add(m));
            context.SaveChanges();
        }
    }
}