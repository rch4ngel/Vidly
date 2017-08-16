namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesWithSampleData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES('StarWars', 1, '01/01/1970 12:00:00', '08/08/2017 12:00:00', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
