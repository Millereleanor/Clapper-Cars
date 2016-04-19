namespace ClappersCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAdTitleToEnum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Price", c => c.Int(nullable: false));
        }
    }
}
