namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zamalek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "confirmPay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "confirmPay");
        }
    }
}
