namespace EmployeMangment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMaritalStatesTableToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaritalStates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaritalStates");
        }
    }
}
