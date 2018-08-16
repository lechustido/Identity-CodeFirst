namespace Identity_con_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AlumnoModels", newName: "Alumno");
            RenameTable(name: "dbo.Cursoes", newName: "Curso");
            RenameTable(name: "dbo.CursoAlumnoModels", newName: "CursoAlumno");
            DropForeignKey("dbo.MatriculaModels", "AlumnoModels_Id", "dbo.AlumnoModels");
            DropIndex("dbo.MatriculaModels", new[] { "AlumnoModels_Id" });
            RenameColumn(table: "dbo.CursoAlumno", name: "AlumnoModels_Id", newName: "Alumno_Id");
            RenameIndex(table: "dbo.CursoAlumno", name: "IX_AlumnoModels_Id", newName: "IX_Alumno_Id");
            CreateTable(
                "dbo.Matricula",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AlumnoId = c.Guid(nullable: false),
                        Curso = c.String(),
                        Precio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .Index(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nombre = c.String(),
                        AlumnoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.AlumnoId, cascadeDelete: true)
                .Index(t => t.AlumnoId);
            
            DropTable("dbo.MatriculaModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MatriculaModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Curso = c.String(),
                        Precio = c.Int(nullable: false),
                        AlumnoModels_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Usuario", "AlumnoId", "dbo.Alumno");
            DropForeignKey("dbo.Matricula", "AlumnoId", "dbo.Alumno");
            DropIndex("dbo.Usuario", new[] { "AlumnoId" });
            DropIndex("dbo.Matricula", new[] { "AlumnoId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Matricula");
            RenameIndex(table: "dbo.CursoAlumno", name: "IX_Alumno_Id", newName: "IX_AlumnoModels_Id");
            RenameColumn(table: "dbo.CursoAlumno", name: "Alumno_Id", newName: "AlumnoModels_Id");
            CreateIndex("dbo.MatriculaModels", "AlumnoModels_Id");
            AddForeignKey("dbo.MatriculaModels", "AlumnoModels_Id", "dbo.AlumnoModels", "Id");
            RenameTable(name: "dbo.CursoAlumno", newName: "CursoAlumnoModels");
            RenameTable(name: "dbo.Curso", newName: "Cursoes");
            RenameTable(name: "dbo.Alumno", newName: "AlumnoModels");
        }
    }
}
