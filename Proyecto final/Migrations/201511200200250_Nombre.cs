namespace Proyecto_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nombre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        idAutor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.idAutor);
            
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        idLibro = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.idLibro);
            
            CreateTable(
                "dbo.Registroes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Password = c.Int(nullable: false),
                        Nombre = c.String(),
                        Edad = c.Int(nullable: false),
                        Telefono = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.Cometarios",
                c => new
                    {
                        Comentario = c.String(nullable: false, maxLength: 128),
                        idcomentario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Comentario);
            
            CreateTable(
                "dbo.RegistroLibroes",
                c => new
                    {
                        Registro_id = c.Int(nullable: false),
                        Libro_idLibro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Registro_id, t.Libro_idLibro })
                .ForeignKey("dbo.Registroes", t => t.Registro_id, cascadeDelete: true)
                .ForeignKey("dbo.Libroes", t => t.Libro_idLibro, cascadeDelete: true)
                .Index(t => t.Registro_id)
                .Index(t => t.Libro_idLibro);
            
            CreateTable(
                "dbo.LibroAutors",
                c => new
                    {
                        Libro_idLibro = c.Int(nullable: false),
                        Autor_idAutor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Libro_idLibro, t.Autor_idAutor })
                .ForeignKey("dbo.Libroes", t => t.Libro_idLibro, cascadeDelete: true)
                .ForeignKey("dbo.Autors", t => t.Autor_idAutor, cascadeDelete: true)
                .Index(t => t.Libro_idLibro)
                .Index(t => t.Autor_idAutor);
            
            CreateTable(
                "dbo.CategoriaLibroes",
                c => new
                    {
                        Categoria_idCategoria = c.Int(nullable: false),
                        Libro_idLibro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Categoria_idCategoria, t.Libro_idLibro })
                .ForeignKey("dbo.Categorias", t => t.Categoria_idCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Libroes", t => t.Libro_idLibro, cascadeDelete: true)
                .Index(t => t.Categoria_idCategoria)
                .Index(t => t.Libro_idLibro);
            
            CreateTable(
                "dbo.CometarioLibroes",
                c => new
                    {
                        Cometario_Comentario = c.String(nullable: false, maxLength: 128),
                        Libro_idLibro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cometario_Comentario, t.Libro_idLibro })
                .ForeignKey("dbo.Cometarios", t => t.Cometario_Comentario, cascadeDelete: true)
                .ForeignKey("dbo.Libroes", t => t.Libro_idLibro, cascadeDelete: true)
                .Index(t => t.Cometario_Comentario)
                .Index(t => t.Libro_idLibro);
            
            AddColumn("dbo.Altas", "Password", c => c.Int(nullable: false));
            AddColumn("dbo.Altas", "Edad", c => c.String());
            AddColumn("dbo.Altas", "Telefono", c => c.String());
            AddColumn("dbo.Altas", "Direccion", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CometarioLibroes", "Libro_idLibro", "dbo.Libroes");
            DropForeignKey("dbo.CometarioLibroes", "Cometario_Comentario", "dbo.Cometarios");
            DropForeignKey("dbo.CategoriaLibroes", "Libro_idLibro", "dbo.Libroes");
            DropForeignKey("dbo.CategoriaLibroes", "Categoria_idCategoria", "dbo.Categorias");
            DropForeignKey("dbo.LibroAutors", "Autor_idAutor", "dbo.Autors");
            DropForeignKey("dbo.LibroAutors", "Libro_idLibro", "dbo.Libroes");
            DropForeignKey("dbo.RegistroLibroes", "Libro_idLibro", "dbo.Libroes");
            DropForeignKey("dbo.RegistroLibroes", "Registro_id", "dbo.Registroes");
            DropIndex("dbo.CometarioLibroes", new[] { "Libro_idLibro" });
            DropIndex("dbo.CometarioLibroes", new[] { "Cometario_Comentario" });
            DropIndex("dbo.CategoriaLibroes", new[] { "Libro_idLibro" });
            DropIndex("dbo.CategoriaLibroes", new[] { "Categoria_idCategoria" });
            DropIndex("dbo.LibroAutors", new[] { "Autor_idAutor" });
            DropIndex("dbo.LibroAutors", new[] { "Libro_idLibro" });
            DropIndex("dbo.RegistroLibroes", new[] { "Libro_idLibro" });
            DropIndex("dbo.RegistroLibroes", new[] { "Registro_id" });
            DropColumn("dbo.Altas", "Direccion");
            DropColumn("dbo.Altas", "Telefono");
            DropColumn("dbo.Altas", "Edad");
            DropColumn("dbo.Altas", "Password");
            DropTable("dbo.CometarioLibroes");
            DropTable("dbo.CategoriaLibroes");
            DropTable("dbo.LibroAutors");
            DropTable("dbo.RegistroLibroes");
            DropTable("dbo.Cometarios");
            DropTable("dbo.Categorias");
            DropTable("dbo.Registroes");
            DropTable("dbo.Libroes");
            DropTable("dbo.Autors");
        }
    }
}
