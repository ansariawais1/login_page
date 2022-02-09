namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesAdded91 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.SignUps", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SignUps", "Gender");
            DropColumn("dbo.Employees", "Gender");
        }
    }
}
