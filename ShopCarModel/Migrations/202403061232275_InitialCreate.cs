namespace ShopCarModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarInfoes",
                c => new
                    {
                        CId = c.Int(nullable: false, identity: true),
                        CName = c.String(nullable: false, maxLength: 100),
                        Cprice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CId);
            
            CreateTable(
                "dbo.OrderInfoes",
                c => new
                    {
                        OId = c.Int(nullable: false, identity: true),
                        CId = c.Int(nullable: false),
                        UId = c.Int(nullable: false),
                        ONumber = c.Int(nullable: false),
                        OPrice = c.Double(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        ORemark = c.String(nullable: false, maxLength: 200),
                        OState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OId)
                .ForeignKey("dbo.CarInfoes", t => t.CId, cascadeDelete: true)
                .ForeignKey("dbo.UserInfoes", t => t.UId, cascadeDelete: true)
                .Index(t => t.CId)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        UId = c.Int(nullable: false, identity: true),
                        UName = c.String(nullable: false, maxLength: 100),
                        UPwd = c.String(nullable: false, maxLength: 100),
                        URealName = c.String(nullable: false, maxLength: 100),
                        UIsAdmin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderInfoes", "UId", "dbo.UserInfoes");
            DropForeignKey("dbo.OrderInfoes", "CId", "dbo.CarInfoes");
            DropIndex("dbo.OrderInfoes", new[] { "UId" });
            DropIndex("dbo.OrderInfoes", new[] { "CId" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.OrderInfoes");
            DropTable("dbo.CarInfoes");
        }
    }
}
