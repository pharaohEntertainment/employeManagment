namespace EmployeMangment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmployesTableInDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nationalId = c.String(nullable: false, maxLength: 14),
                        name = c.String(nullable: false),
                        mobileNumber = c.String(nullable: false, maxLength: 11),
                        address = c.String(nullable: false),
                        disablityPrecentage = c.Int(nullable: false),
                        birthDate = c.DateTime(nullable: false),
                        contractionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employes");
        }
    }
}
