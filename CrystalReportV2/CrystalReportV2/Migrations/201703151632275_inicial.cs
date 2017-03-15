namespace CrystalReportV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        pkProducto = c.Int(nullable: false, identity: true),
                        sNombreCorto = c.String(nullable: false, unicode: false),
                        sDescripcion = c.String(nullable: false, unicode: false),
                        dPrecio = c.Double(nullable: false),
                        dCosto = c.Double(nullable: false),
                        iStock = c.Int(nullable: false),
                        sCategoria = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkProducto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
        }
    }
}
