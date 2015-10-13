using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceyWebApp.ViewModels
{
    public class GroceyMain
    {
        public Guid ListId { get; set; }
        public string ListName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}