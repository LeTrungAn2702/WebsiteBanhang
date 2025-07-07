namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table_Review : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Review", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Review", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
