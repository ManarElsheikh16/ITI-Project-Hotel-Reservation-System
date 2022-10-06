namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zamzam : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "paymentID", "dbo.Gusets");
            AddColumn("dbo.Bookings", "reserve", c => c.Boolean(nullable: false));
            AddForeignKey("dbo.Payments", "paymentID", "dbo.Bookings", "bookID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "paymentID", "dbo.Bookings");
            DropColumn("dbo.Bookings", "reserve");
            AddForeignKey("dbo.Payments", "paymentID", "dbo.Gusets", "gusID");
        }
    }
}
