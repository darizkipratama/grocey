using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GroceyWebApp.Models
{
    public class MasterListModel
    {
        [Key]
        public Guid ListId { get; set; }
        public string ListName { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<DetailListModel> Details { get; set; }
    }
}