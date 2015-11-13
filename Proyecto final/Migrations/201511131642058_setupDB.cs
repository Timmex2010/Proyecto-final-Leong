namespace Proyecto_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setupDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Altas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Altas");
        }
    }
}
