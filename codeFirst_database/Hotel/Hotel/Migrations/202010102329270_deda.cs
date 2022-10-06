namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "roomType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "roomType");
        }
    }
}
