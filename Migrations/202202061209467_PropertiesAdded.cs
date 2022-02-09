namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesAdded : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Emps", newName: "Employees");
            DropForeignKey("dbo.DesignationS", "User_I_ID", "dbo.User_I");
            DropIndex("dbo.DesignationS", new[] { "User_I_ID" });
            CreateTable(
                "dbo.SignUps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserName = c.String(),
                        ContectNumber = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.DesignationS");
            DropTable("dbo.User_I");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User_I",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(),
                        ContectNumber = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DesignationS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        User_I_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.SignUps");
            CreateIndex("dbo.DesignationS", "User_I_ID");
            AddForeignKey("dbo.DesignationS", "User_I_ID", "dbo.User_I", "ID");
            RenameTable(name: "dbo.Employees", newName: "Emps");
        }
    }
}
