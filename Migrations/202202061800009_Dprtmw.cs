namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dprtmw : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Employees", "Department_id", c => c.Int());
            CreateIndex("dbo.Employees", "Department_id");
            AddForeignKey("dbo.Employees", "Department_id", "dbo.Departments", "id");
            DropColumn("dbo.Employees", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Department", c => c.String(nullable: false));
            DropForeignKey("dbo.Employees", "Department_id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_id" });
            DropColumn("dbo.Employees", "Department_id");
            DropTable("dbo.Departments");
        }
    }
}
