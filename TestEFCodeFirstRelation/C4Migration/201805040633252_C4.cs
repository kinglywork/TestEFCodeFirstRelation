namespace TestEFCodeFirstRelation.C4Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class C4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.C4Grade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.C4Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.C4Grade", t => t.Grade_Id)
                .Index(t => t.Grade_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.C4Student", "Grade_Id", "dbo.C4Grade");
            DropIndex("dbo.C4Student", new[] { "Grade_Id" });
            DropTable("dbo.C4Student");
            DropTable("dbo.C4Grade");
        }
    }
}
