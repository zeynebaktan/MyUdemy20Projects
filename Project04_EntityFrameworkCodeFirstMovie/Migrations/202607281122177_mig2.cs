namespace Project04_EntityFrameworkCodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Movie_MovieId", c => c.Int());
            CreateIndex("dbo.Movies", "CategoryId");
            CreateIndex("dbo.Movies", "Movie_MovieId");
            AddForeignKey("dbo.Movies", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "Movie_MovieId", "dbo.Movies", "MovieId");
            DropColumn("dbo.Movies", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Category", c => c.String());
            DropForeignKey("dbo.Movies", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.Movies", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "Movie_MovieId" });
            DropIndex("dbo.Movies", new[] { "CategoryId" });
            DropColumn("dbo.Movies", "Movie_MovieId");
            DropColumn("dbo.Movies", "CategoryId");
        }
    }
}
