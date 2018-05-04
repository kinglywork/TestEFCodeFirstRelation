namespace TestEFCodeFirstRelation.C1Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneToMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.C1Grade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.C1Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.C1Grade", t => t.Grade_Id)
                .Index(t => t.Grade_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.C1Student", "Grade_Id", "dbo.C1Grade");
            DropIndex("dbo.C1Student", new[] { "Grade_Id" });
            DropTable("dbo.C1Student");
            DropTable("dbo.C1Grade");
        }
    }
}
