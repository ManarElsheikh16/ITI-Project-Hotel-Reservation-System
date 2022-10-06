namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saso : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "paymentID", "dbo.Bookings");
            DropIndex("dbo.Payments", new[] { "paymentID" });
            AddColumn("dbo.Bookings", "confirmPay", c => c.Boolean(nullable: false));
            DropTable("dbo.Payments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        paymentID = c.Int(nullable: false),
                        paymentDate = c.DateTime(nullable: false),
                        discount = c.Int(nullable: false),
                        confirmPay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.paymentID);
            
            DropColumn("dbo.Bookings", "confirmPay");
            CreateIndex("dbo.Payments", "paymentID");
            AddForeignKey("dbo.Payments", "paymentID", "dbo.Bookings", "bookID");
        }
    }
}
