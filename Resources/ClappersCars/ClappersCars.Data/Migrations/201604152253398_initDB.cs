namespace ClappersCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRequestForms",
                c => new
                    {
                        UserRequestFormID = c.Int(nullable: false, identity: true),
                        VehicleID = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        BestTimeToCall = c.Int(nullable: false),
                        PreferredContactMethod = c.Int(nullable: false),
                        TimeframeToPurchaseStart = c.DateTime(nullable: false),
                        TimeframeToPurchaseEnd = c.DateTime(nullable: false),
                        AdditionalInformation = c.String(),
                        LastContactDate = c.DateTime(nullable: false),
                        StatusOfRequest = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserRequestFormID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.VehicleID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleID = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Mileage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdTitle = c.Int(nullable: false),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                        UrlOfPicture = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        Condition = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRequestForms", "VehicleID", "dbo.Vehicles");
            DropIndex("dbo.UserRequestForms", new[] { "VehicleID" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.UserRequestForms");
        }
    }
}
