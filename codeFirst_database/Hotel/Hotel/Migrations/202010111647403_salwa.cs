namespace Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class salwa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gusets", "phone", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Gusets", "SSN", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gusets", "SSN", c => c.String(maxLength: 14));
            AlterColumn("dbo.Gusets", "phone", c => c.String(maxLength: 11));
        }
    }
}
