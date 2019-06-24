namespace StoreCSharpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhhdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        products_id = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        Order_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.Order_id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.products_id, cascadeDelete: true)
                .Index(t => t.products_id)
                .Index(t => t.Order_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "products_id", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Order_id", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "Order_id" });
            DropIndex("dbo.OrderDetails", new[] { "products_id" });
            DropTable("dbo.OrderDetails");
        }
    }
}
