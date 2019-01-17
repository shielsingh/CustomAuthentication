namespace CustomAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultRole_User : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Roles (RoleName) Values('SuperAdmin')");
            Sql("INSERT INTO Roles (RoleName) Values('Admin')");
            Sql("INSERT INTO Roles (RoleName) Values('User')");
            Sql("INSERT INTO Users (Username,FirstName,LastName,Email,Password,IsActive,ActivationCode) Values('SuperAdmin','Super','Admin','sushil.singh@basware.com','Shiel@123',1,'BE310E8D-FFCB-4600-B6FE-4067942E675C')");
            Sql("INSERT INTO UserRoles (UserId,RoleId) Values(1,1)");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Roles WHERE RoleId IN (1,2,3)");
            Sql("DELETE FROM Users WHERE UserId IN (1)");
            Sql("DELETE FROM UserRoles WHERE UserId IN (1) AND RoleId IN (1)");
        }
    }
}
