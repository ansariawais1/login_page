    namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesAdded121 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deparments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Department = c.String(),
                        Employee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_ID)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deparments", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.Deparments", new[] { "Employee_ID" });
            DropTable("dbo.Deparments");
        }
    }
}
