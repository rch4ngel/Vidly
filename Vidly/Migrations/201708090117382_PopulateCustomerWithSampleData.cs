namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerWithSampleData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CUSTOMERS (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES('Luke Skywalker', 1, 4, '03/30/1976 12:00:00')");
        }
        
        public override void Down()
        {
        }
    }
}
