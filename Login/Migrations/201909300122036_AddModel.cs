namespace Login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_M_User");
        }
    }
}
