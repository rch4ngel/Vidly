namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, NAME) VALUES (1, 'Action')");
            Sql("INSERT INTO GENRES (Id, NAME) VALUES (2, 'Comedy')");
            Sql("INSERT INTO GENRES (Id, NAME) VALUES (3, 'Family')");
            Sql("INSERT INTO GENRES (Id, NAME) VALUES (4, 'Horror')");
            Sql("INSERT INTO GENRES (Id, NAME) VALUES (5, 'Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
