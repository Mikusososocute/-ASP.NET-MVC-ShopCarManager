namespace ShopCarModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredOremake : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderInfoes", "ORemark", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderInfoes", "ORemark", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
