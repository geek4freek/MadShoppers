namespace MadShoppers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mainclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customerclasses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                        phonenumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Itemclasses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        image = c.Byte(nullable: false),
                        price = c.Single(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.purchaseclasses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        itemid = c.Int(nullable: false),
                        customerid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customerclasses", t => t.customerid, cascadeDelete: true)
                .ForeignKey("dbo.Itemclasses", t => t.itemid, cascadeDelete: true)
                .Index(t => t.customerid)
                .Index(t => t.itemid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.purchaseclasses", "itemid", "dbo.Itemclasses");
            DropForeignKey("dbo.purchaseclasses", "customerid", "dbo.Customerclasses");
            DropIndex("dbo.purchaseclasses", new[] { "itemid" });
            DropIndex("dbo.purchaseclasses", new[] { "customerid" });
            DropTable("dbo.purchaseclasses");
            DropTable("dbo.Itemclasses");
            DropTable("dbo.Customerclasses");
        }
    }
}
