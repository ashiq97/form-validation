namespace MVC_Database.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedsitetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        SiteName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Site_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Site_Id");
            AddForeignKey("dbo.Employees", "Site_Id", "dbo.Sites", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Site_Id", "dbo.Sites");
            DropIndex("dbo.Employees", new[] { "Site_Id" });
            DropColumn("dbo.Employees", "Site_Id");
            DropTable("dbo.Sites");
        }
    }
}
