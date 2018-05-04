namespace TestEFCodeFirstRelation.C3Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class C3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.C3Grade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.C3Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.C3Grade", t => t.Grade_Id)
                .Index(t => t.Grade_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.C3Student", "Grade_Id", "dbo.C3Grade");
            DropIndex("dbo.C3Student", new[] { "Grade_Id" });
            DropTable("dbo.C3Student");
            DropTable("dbo.C3Grade");
        }
    }
}
