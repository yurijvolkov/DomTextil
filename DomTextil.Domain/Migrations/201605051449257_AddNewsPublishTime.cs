namespace DomTextil.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewsPublishTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "PublisTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "PublisTime");
        }
    }
}
