namespace MadShoppers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enable_users : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.AspNetRoles values(1,'can_manage_new_products')");
            Sql("insert into dbo.AspNetRoles values(2,'only_viewing_permision')");
        }
        
        public override void Down()
        {
        }
    }
}
