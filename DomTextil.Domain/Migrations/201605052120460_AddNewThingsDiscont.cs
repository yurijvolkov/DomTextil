namespace DomTextil.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewThingsDiscont : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "Discriminator");
        }
    }
}
