namespace Proyecto_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablas : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Altas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Altas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Password = c.Int(nullable: false),
                        Nombre = c.String(),
                        Edad = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
