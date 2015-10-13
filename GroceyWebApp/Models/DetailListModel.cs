using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GroceyWebApp.Models
{
    public class DetailListModel
    {
        [Key]
        public Guid DetailId { get; set; }
        public string DetailName { get; set; }
        public int DetailQty { get; set; }
        public string DetailsUom { get; set; }
        public virtual MasterListModel parent { get; set; }
    }
}