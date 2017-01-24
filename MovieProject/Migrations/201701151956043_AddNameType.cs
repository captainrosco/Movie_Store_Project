namespace MovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "NameType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "NameType");
        }
    }
}
