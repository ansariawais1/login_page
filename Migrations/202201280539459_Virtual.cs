namespace LogginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Virtual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DesignationS", "User_I_ID", c => c.Int());
            CreateIndex("dbo.DesignationS", "User_I_ID");
            AddForeignKey("dbo.DesignationS", "User_I_ID", "dbo.User_I", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DesignationS", "User_I_ID", "dbo.User_I");
            DropIndex("dbo.DesignationS", new[] { "User_I_ID" });
            DropColumn("dbo.DesignationS", "User_I_ID");
        }
    }
}
