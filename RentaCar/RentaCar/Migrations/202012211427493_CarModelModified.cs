namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarModelModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Cars", "IsBooked");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "IsBooked", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Cars", "Name", c => c.String());
        }
    }
}
