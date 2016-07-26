namespace DomTextil.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewThingsDiscont3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.News", newName: "Discounts");
            CreateTable(
                "dbo.News",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Photo = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                        PublisTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NewThings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Photo = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                        PublisTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Discounts", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Discounts", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.NewThings");
            DropTable("dbo.News");
            RenameTable(name: "dbo.Discounts", newName: "News");
        }
    }
}
