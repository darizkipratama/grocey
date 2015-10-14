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
        }
    }
}
