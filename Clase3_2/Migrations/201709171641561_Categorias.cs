namespace Clase3_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categorias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DiadeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tecnico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        FechaNacimiento = c.DateTime(),
                        Nacionalidad = c.String(),
                        DiadeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaterialesCategoria",
                c => new
                    {
                        Materiales_Id = c.Int(nullable: false),
                        Categoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Materiales_Id, t.Categoria_Id })
                .ForeignKey("dbo.Materiales", t => t.Materiales_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id, cascadeDelete: true)
                .Index(t => t.Materiales_Id)
                .Index(t => t.Categoria_Id);
            
            AddColumn("dbo.Materiales", "TecnicoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Materiales", "TecnicoId");
            AddForeignKey("dbo.Materiales", "TecnicoId", "dbo.Tecnico", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materiales", "TecnicoId", "dbo.Tecnico");
            DropForeignKey("dbo.MaterialesCategoria", "Categoria_Id", "dbo.Categoria");
            DropForeignKey("dbo.MaterialesCategoria", "Materiales_Id", "dbo.Materiales");
            DropIndex("dbo.MaterialesCategoria", new[] { "Categoria_Id" });
            DropIndex("dbo.MaterialesCategoria", new[] { "Materiales_Id" });
            DropIndex("dbo.Materiales", new[] { "TecnicoId" });
            DropColumn("dbo.Materiales", "TecnicoId");
            DropTable("dbo.MaterialesCategoria");
            DropTable("dbo.Tecnico");
            DropTable("dbo.Categoria");
        }
    }
}
