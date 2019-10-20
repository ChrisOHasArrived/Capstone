namespace CollabFast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropalltables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
    "dbo.ToDoes",
    c => new
    {
        ID = c.Guid(nullable: false, identity: true),
        Name = c.String(),
        Assignee = c.String(),
        DueDate = c.DateTime(nullable: false),
        Priority = c.Int(nullable: false),
    })
    .PrimaryKey(t => t.ID);
            DropTable("dbo.ToDoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ToDoes",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Assignee = c.String(),
                        DueDate = c.DateTime(nullable: false),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
