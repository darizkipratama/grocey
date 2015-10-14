using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using GroceyWebApp.Models;

namespace GroceyWebApp.Controllers
{
    public class SeedController : ApiController
    {
        DataContext db = new DataContext();

        public string Get()
        {
            var MasterList = new List<MasterListModel>
            {
                new MasterListModel
                {
                    ListId = Guid.NewGuid(),
                    ListName = "List No.1",
                    CreatedDate = DateTime.Now,
                    Details = new List<DetailListModel>
                    {
                        new DetailListModel
                        {
                            DetailId = Guid.NewGuid(),
                            DetailName = "Susu Bendera 00",
                            DetailQty = 2,
                            DetailsUom = "Pack",
                        },
                        new DetailListModel
                        {
                            DetailId = Guid.NewGuid(),
                            DetailName = "Gula Pasir 00",
                            DetailQty = 6,
                            DetailsUom = "Kg",
                        },
                        new DetailListModel
                        {
                            DetailId = Guid.NewGuid(),
                            DetailName = "Permen Polo 00",
                            DetailQty = 2,
                            DetailsUom = "Pack",
                        },
                    }
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
            MasterList.ForEach(m => db.masterList.Add(m));
            db.SaveChanges();

            return ("Data Updated!");
        }
    }
}
