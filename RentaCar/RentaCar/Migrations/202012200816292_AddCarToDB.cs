namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Instore = c.Byte(nullable: false),
                        IsBooked = c.Boolean(nullable: false),
                        CarTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarTypes", t => t.CarTypeId, cascadeDelete: true)
                .Index(t => t.CarTypeId);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
        }
    }
}
