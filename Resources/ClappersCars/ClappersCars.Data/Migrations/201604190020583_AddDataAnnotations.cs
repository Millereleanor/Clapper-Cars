namespace ClappersCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserRequestForms", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.UserRequestForms", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.UserRequestForms", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserRequestForms", "Phone", c => c.String());
            AlterColumn("dbo.UserRequestForms", "Email", c => c.String());
            AlterColumn("dbo.UserRequestForms", "Name", c => c.String());
        }
    }
}
