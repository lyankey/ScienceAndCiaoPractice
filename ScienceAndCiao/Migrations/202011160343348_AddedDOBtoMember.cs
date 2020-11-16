namespace ScienceAndCiao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDOBtoMember : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id" });
            RenameColumn(table: "dbo.Members", name: "MembershipType_Id", newName: "MembershipTypeId");
            AddColumn("dbo.Members", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.Members", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Members", "MembershipTypeId");
            AddForeignKey("dbo.Members", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Members", "MembershipTypeId", c => c.Byte());
            DropColumn("dbo.Members", "Birthdate");
            RenameColumn(table: "dbo.Members", name: "MembershipTypeId", newName: "MembershipType_Id");
            CreateIndex("dbo.Members", "MembershipType_Id");
            AddForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
