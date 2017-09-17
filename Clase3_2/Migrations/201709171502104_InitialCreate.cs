namespace Clase3_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materiales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CantidadUtilizada = c.Int(nullable: false),
                        Nombre = c.String(),
                        CodigoMaterial = c.String(),
                        CantidadSalida = c.Int(nullable: false),
                        Stock = c.String(),
                        DiadeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Materiales");
        }
    }
}
