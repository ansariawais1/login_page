namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesAdded12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogInPages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.SignUps", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.SignUps", "Address", c => c.String(nullable: false));
            DropColumn("dbo.SignUps", "Name");
            DropColumn("dbo.SignUps", "ContectNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SignUps", "ContectNumber", c => c.String(nullable: false));
            AddColumn("dbo.SignUps", "Name", c => c.String(nullable: false));
            DropColumn("dbo.SignUps", "Address");
            DropColumn("dbo.SignUps", "DOB");
            DropTable("dbo.LogInPages");
        }
    }
}
