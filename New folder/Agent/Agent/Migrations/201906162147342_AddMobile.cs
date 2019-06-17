namespace Agent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMobile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Phone", c => c.String());
            AddColumn("dbo.Users", "Mobile", c => c.String());
            AddColumn("dbo.Users", "City", c => c.String());
            AddColumn("dbo.Users", "State", c => c.String());
            AddColumn("dbo.Users", "PostalCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PostalCode");
            DropColumn("dbo.Users", "State");
            DropColumn("dbo.Users", "City");
            DropColumn("dbo.Users", "Mobile");
            DropColumn("dbo.Users", "Phone");
        }
    }
}
