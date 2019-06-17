namespace Agent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreated1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Created", c => c.DateTime(nullable: false));
        }
    }
}
