namespace Agent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMarkup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Markup", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Markup");
        }
    }
}
