namespace TestEFCodeFirstRelation.C2Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class C2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.C2Grade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.C2Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        C2Grade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.C2Grade", t => t.C2Grade_Id)
                .Index(t => t.C2Grade_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.C2Student", "C2Grade_Id", "dbo.C2Grade");
            DropIndex("dbo.C2Student", new[] { "C2Grade_Id" });
            DropTable("dbo.C2Student");
            DropTable("dbo.C2Grade");
        }
    }
}
