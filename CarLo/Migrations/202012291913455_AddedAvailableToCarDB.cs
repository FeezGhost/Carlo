namespace CarLo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAvailableToCarDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "AvailableInstore", c => c.Byte(nullable: false));
            Sql("UPDATE Cars SET AvailableInstore = Instore");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "AvailableInstore");
        }
    }
}
