namespace CrystalReportV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddepartamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "sDepartamento", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Productos", "sCategoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productos", "sCategoria", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Productos", "sDepartamento");
        }
    }
}
