namespace ScienceAndCiao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMemberNames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipTypeId" });
            RenameColumn(table: "dbo.Members", name: "MembershipTypeId", newName: "MembershipType_Id");
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
            AlterColumn("dbo.Members", "MembershipType_Id", c => c.Byte());
            CreateIndex("dbo.Members", "MembershipType_Id");
            AddForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id" });
            AlterColumn("dbo.Members", "MembershipType_Id", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "MembershipName");
            RenameColumn(table: "dbo.Members", name: "MembershipType_Id", newName: "MembershipTypeId");
            CreateIndex("dbo.Members", "MembershipTypeId");
            AddForeignKey("dbo.Members", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
