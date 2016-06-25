namespace Ghsaa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "myEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "myEmail", c => c.String());
        }
    }
}
