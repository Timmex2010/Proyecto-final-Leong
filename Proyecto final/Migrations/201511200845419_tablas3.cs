namespace Proyecto_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablas3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CometarioLibroes", "Cometario_Comentario", "dbo.Cometarios");
            DropIndex("dbo.CometarioLibroes", new[] { "Cometario_Comentario" });
            RenameColumn(table: "dbo.CometarioLibroes", name: "Cometario_Comentario", newName: "Cometario_idcomentario");
            DropPrimaryKey("dbo.Cometarios");
            DropPrimaryKey("dbo.CometarioLibroes");
            AlterColumn("dbo.Cometarios", "Comentario", c => c.String());
            AlterColumn("dbo.Cometarios", "idcomentario", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CometarioLibroes", "Cometario_idcomentario", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Cometarios", "idcomentario");
            AddPrimaryKey("dbo.CometarioLibroes", new[] { "Cometario_idcomentario", "Libro_idLibro" });
            CreateIndex("dbo.CometarioLibroes", "Cometario_idcomentario");
            AddForeignKey("dbo.CometarioLibroes", "Cometario_idcomentario", "dbo.Cometarios", "idcomentario", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CometarioLibroes", "Cometario_idcomentario", "dbo.Cometarios");
            DropIndex("dbo.CometarioLibroes", new[] { "Cometario_idcomentario" });
            DropPrimaryKey("dbo.CometarioLibroes");
            DropPrimaryKey("dbo.Cometarios");
            AlterColumn("dbo.CometarioLibroes", "Cometario_idcomentario", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Cometarios", "idcomentario", c => c.Int(nullable: false));
            AlterColumn("dbo.Cometarios", "Comentario", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.CometarioLibroes", new[] { "Cometario_Comentario", "Libro_idLibro" });
            AddPrimaryKey("dbo.Cometarios", "Comentario");
            RenameColumn(table: "dbo.CometarioLibroes", name: "Cometario_idcomentario", newName: "Cometario_Comentario");
            CreateIndex("dbo.CometarioLibroes", "Cometario_Comentario");
            AddForeignKey("dbo.CometarioLibroes", "Cometario_Comentario", "dbo.Cometarios", "Comentario", cascadeDelete: true);
        }
    }
}
