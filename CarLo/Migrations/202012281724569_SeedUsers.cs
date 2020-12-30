namespace CarLo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'399e60e3-1e8f-446e-b29a-d4993795240e', N'feezoocrazy420@gmail.com', 0, N'ALsWldzLwF8DBjRTYhEK4z2zuyb3oZ2SOaqXTZWzbC3Q+jRIWuatG9RvjyjbfTCCGA==', N'71d976c6-de43-499d-9b10-62ded94bf912', NULL, 0, 0, NULL, 1, 0, N'feezoocrazy420@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aa3c25cf-6505-41b2-b8fd-27a97dc7f5b5', N'admin@CarLo.com', 0, N'AEKpRRAIqcXrkAFNIYF/uoyRa1lpHopTcKtJrmGj5jQV6u57m+G4nC3cEvi46TzHaQ==', N'1b60ebb8-ecfb-4697-9ca2-a5d5d39689a5', NULL, 0, 0, NULL, 1, 0, N'admin@CarLo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e652f267-30f8-4972-a689-b85a84270711', N'guest@CarLo.com', 0, N'AG/2dONUalstZc7ez2jT7q7r3k5rOR/n6vJi1EzF8lyUcJTM6p6vMIgNHScrdayBwg==', N'919711a9-f6f2-47b5-a8e5-ccca6e4dd9fe', NULL, 0, 0, NULL, 1, 0, N'guest@CarLo.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3cec46c8-f62c-45a3-920e-93622dc00ff3', N'CanManageCars')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aa3c25cf-6505-41b2-b8fd-27a97dc7f5b5', N'3cec46c8-f62c-45a3-920e-93622dc00ff3')

");
        }
        
        public override void Down()
        {
        }
    }
}
