namespace GroceyWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailListModels", "ItemBought", c => c.Boolean(nullable: false));
            AddColumn("dbo.DetailListModels", "RowEdited", c => c.DateTime(nullable: false));
            AddColumn("dbo.MasterListModels", "UserCreated_Id", c => c.Guid());
            CreateIndex("dbo.MasterListModels", "UserCreated_Id");
            AddForeignKey("dbo.MasterListModels", "UserCreated_Id", "dbo.UserModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MasterListModels", "UserCreated_Id", "dbo.UserModels");
            DropIndex("dbo.MasterListModels", new[] { "UserCreated_Id" });
            DropColumn("dbo.MasterListModels", "UserCreated_Id");
            DropColumn("dbo.DetailListModels", "RowEdited");
            DropColumn("dbo.DetailListModels", "ItemBought");
        }
    }
}
