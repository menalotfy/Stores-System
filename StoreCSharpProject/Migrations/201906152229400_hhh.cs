namespace StoreCSharpProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhh : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SalesOrders", new[] { "SalesRepresentative_ID" });
            CreateIndex("dbo.SalesOrders", "SalesRepresentative_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SalesOrders", new[] { "SalesRepresentative_id" });
            CreateIndex("dbo.SalesOrders", "SalesRepresentative_ID");
        }
    }
}
