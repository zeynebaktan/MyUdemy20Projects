namespace Project04_EntityFrameworkCodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_extra_column : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "Movie_MovieId" });
            DropColumn("dbo.Movies", "Movie_MovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Movie_MovieId", c => c.Int());
            CreateIndex("dbo.Movies", "Movie_MovieId");
            AddForeignKey("dbo.Movies", "Movie_MovieId", "dbo.Movies", "MovieId");
        }
    }
}
