namespace TreeView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        SectionId = c.Int(nullable: false, identity: true),
                        SectionName = c.String(nullable: false),
                        NavUrl = c.String(),
                        ParentSecId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SectionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sections");
        }
    }
}
