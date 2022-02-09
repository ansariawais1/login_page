namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyCang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emps", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Emps", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.Emps", "DOJ", c => c.DateTime(nullable: false));
            DropColumn("dbo.Emps", "ContectNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Emps", "ContectNumber", c => c.String(nullable: false));
            DropColumn("dbo.Emps", "DOJ");
            DropColumn("dbo.Emps", "DOB");
            DropColumn("dbo.Emps", "Address");
        }
    }
}
