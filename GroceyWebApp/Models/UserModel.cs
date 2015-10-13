using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GroceyWebApp.Models
{
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime DateCreated { get; set; }
    }
}