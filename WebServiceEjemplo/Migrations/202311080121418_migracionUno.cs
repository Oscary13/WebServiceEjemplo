namespace WebServiceEjemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracionUno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Double(nullable: false),
                        CantidadStock = c.String(),
                        CantidadVendido = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Producto");
        }
    }
}
