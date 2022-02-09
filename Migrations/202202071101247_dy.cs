namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Department_id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_id" });
            AddColumn("dbo.Employees", "Department", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "Department_id");
            DropTable("dbo.Departments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Employees", "Department_id", c => c.Int());
            DropColumn("dbo.Employees", "Department");
            CreateIndex("dbo.Employees", "Department_id");
            AddForeignKey("dbo.Employees", "Department_id", "dbo.Departments", "id");
        }
    }
}
