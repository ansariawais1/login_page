namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesAdded9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Deparments", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.Deparments", new[] { "Employee_ID" });
            AddColumn("dbo.Employees", "Department", c => c.String(nullable: false));
            DropTable("dbo.Deparments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Deparments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Department = c.String(),
                        Employee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Employees", "Department");
            CreateIndex("dbo.Deparments", "Employee_ID");
            AddForeignKey("dbo.Deparments", "Employee_ID", "dbo.Employees", "ID");
        }
    }
}
