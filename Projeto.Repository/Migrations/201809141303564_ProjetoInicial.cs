namespace Projeto.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjetoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        IdAluno = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Matricula = c.String(nullable: false),
                        IdTurma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAluno)
                .ForeignKey("dbo.Turma", t => t.IdTurma, cascadeDelete: true)
                .Index(t => t.IdTurma);
            
            CreateTable(
                "dbo.Prova",
                c => new
                    {
                        IdProva = c.Int(nullable: false, identity: true),
                        Nota = c.String(nullable: false, maxLength: 50),
                        IdAluno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProva)
                .ForeignKey("dbo.Aluno", t => t.IdAluno, cascadeDelete: true)
                .Index(t => t.IdAluno);
            
            CreateTable(
                "dbo.Turma",
                c => new
                    {
                        IdTurma = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Turno = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdTurma);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "IdTurma", "dbo.Turma");
            DropForeignKey("dbo.Prova", "IdAluno", "dbo.Aluno");
            DropIndex("dbo.Prova", new[] { "IdAluno" });
            DropIndex("dbo.Aluno", new[] { "IdTurma" });
            DropTable("dbo.Turma");
            DropTable("dbo.Prova");
            DropTable("dbo.Aluno");
        }
    }
}
