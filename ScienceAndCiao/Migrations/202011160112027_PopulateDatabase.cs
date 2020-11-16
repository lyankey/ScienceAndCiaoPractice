namespace ScienceAndCiao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, SubscriptionDuration, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, SubscriptionDuration, DiscountRate) VALUES (2, 0, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, SubscriptionDuration, DiscountRate) VALUES (3, 0, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, SubscriptionDuration, DiscountRate) VALUES (4, 0, 6, 20)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, SubscriptionDuration, DiscountRate) VALUES (5, 0, 12, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
