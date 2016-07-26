namespace DomTextil.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Photo = c.String(),
                        Description = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
