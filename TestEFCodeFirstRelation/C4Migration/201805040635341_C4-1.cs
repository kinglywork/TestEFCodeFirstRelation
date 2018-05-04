namespace TestEFCodeFirstRelation.C4Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class C41 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.C4Student", "Grade_Id", "dbo.C4Grade");
            DropIndex("dbo.C4Student", new[] { "Grade_Id" });
            RenameColumn(table: "dbo.C4Student", name: "Grade_Id", newName: "GradeId");
            AlterColumn("dbo.C4Student", "GradeId", c => c.Int(nullable: false));
            CreateIndex("dbo.C4Student", "GradeId");
            AddForeignKey("dbo.C4Student", "GradeId", "dbo.C4Grade", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.C4Student", "GradeId", "dbo.C4Grade");
            DropIndex("dbo.C4Student", new[] { "GradeId" });
            AlterColumn("dbo.C4Student", "GradeId", c => c.Int());
            RenameColumn(table: "dbo.C4Student", name: "GradeId", newName: "Grade_Id");
            CreateIndex("dbo.C4Student", "Grade_Id");
            AddForeignKey("dbo.C4Student", "Grade_Id", "dbo.C4Grade", "Id");
        }
    }
}
