namespace Agent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlightAPIs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FlightAPIs", c => c.String());
            AddColumn("dbo.Users", "AgentType", c => c.String());
            AddColumn("dbo.Users", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Status");
            DropColumn("dbo.Users", "AgentType");
            DropColumn("dbo.Users", "FlightAPIs");
        }
    }
}
