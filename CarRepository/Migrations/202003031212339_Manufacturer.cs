namespace CarRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Manufacturer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "ManufacturerId", c => c.Int(nullable: false));
            AddColumn("dbo.Details", "ManufacturerId", c => c.Int(nullable: false));
            AddColumn("dbo.Details", "DetTypeId", c => c.Int(nullable: false /*defaultValue: 1*/));
            CreateIndex("dbo.Cars", "ManufacturerId");
            CreateIndex("dbo.Details", "ManufacturerId");
            CreateIndex("dbo.Details", "DetTypeId");
            Sql("insert into Manufacturers (name) values ('Not Selected')");
            Sql("UPDATE Cars SET ManufacturerId = 1");
            Sql("insert into DetTypes (type) values ('Not Selected')");
            Sql("UPDATE Details SET DetTypeId = 1");
            Sql("UPDATE Details SET ManufacturerId = 1");
            AddForeignKey("dbo.Cars", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Details", "DetTypeId", "dbo.DetTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Details", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Details", "DetTypeId", "dbo.DetTypes");
            DropForeignKey("dbo.Cars", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Details", new[] { "DetTypeId" });
            DropIndex("dbo.Details", new[] { "ManufacturerId" });
            DropIndex("dbo.Cars", new[] { "ManufacturerId" });
            DropColumn("dbo.Details", "DetTypeId");
            DropColumn("dbo.Details", "ManufacturerId");
            DropColumn("dbo.Cars", "ManufacturerId");
            DropTable("dbo.DetTypes");
            DropTable("dbo.Manufacturers");
        }
    }
}
