namespace EmployeMangment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ccd91114-9009-4a35-af2d-050eaae687f0', N'admin@cc.com', 0, N'AAB3AXR12YrwG9QBp5KLo616Nsbdgvj1rLBsTxjwMyErMhnrb3kNEf0aagBdiG8hwg==', N'83e6038e-dc85-40dc-b00e-bfbd52e68616', NULL, 0, 0, NULL, 1, 0, N'admin@cc.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5273f9e4-0460-45ef-8a5a-f66c4bca48af', N'admin')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ccd91114-9009-4a35-af2d-050eaae687f0', N'5273f9e4-0460-45ef-8a5a-f66c4bca48af')
               ");
        }
        
        public override void Down()
        {
        }
    }
}
