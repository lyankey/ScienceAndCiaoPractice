namespace ScienceAndCiao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'No Commitment' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Three Months' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'One Year' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
