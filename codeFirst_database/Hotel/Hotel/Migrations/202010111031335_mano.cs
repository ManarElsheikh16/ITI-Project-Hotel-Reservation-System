namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mano : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Payments", "roomType");
            DropColumn("dbo.Payments", "amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "amount", c => c.Double(nullable: false));
            AddColumn("dbo.Payments", "roomType", c => c.String());
        }
    }
}
