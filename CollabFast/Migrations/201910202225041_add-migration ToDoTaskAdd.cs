namespace CollabFast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationToDoTaskAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoTasks",
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
        
        public override void Down()
        {
            DropTable("dbo.ToDoTasks");
        }
    }
}
