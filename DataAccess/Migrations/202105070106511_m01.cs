namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutDetails1 = c.String(maxLength: 1000),
                        AboutDetails2 = c.String(maxLength: 100),
                        AboutImage1 = c.String(maxLength: 150),
                        AboutImage2 = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 50),
                        CategoryDescription = c.String(maxLength: 200),
                        CategoryStatus = c.Boolean(nullable: false),
                        Heading_HeadingId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Headings", t => t.Heading_HeadingId)
                .Index(t => t.Heading_HeadingId);
            
            CreateTable(
                "dbo.Headings",
                c => new
                    {
                        HeadingId = c.Int(nullable: false, identity: true),
                        HeadingName = c.String(maxLength: 50),
                        HeadingDate = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        WriterId = c.Int(nullable: false),
                        Category_CategoryId = c.Int(),
                        Category_CategoryId1 = c.Int(),
                    })
                .PrimaryKey(t => t.HeadingId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .ForeignKey("dbo.Writers", t => t.WriterId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId1)
                .Index(t => t.WriterId)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Category_CategoryId1);
            
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        WriterId = c.Int(nullable: false, identity: true),
                        WriterName = c.String(maxLength: 50),
                        WriterSurname = c.String(maxLength: 50),
                        WriterImage = c.String(maxLength: 150),
                        WriterMail = c.String(maxLength: 100),
                        WriterPassWord = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.WriterId);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        ContentId = c.Int(nullable: false, identity: true),
                        ContentValue = c.String(maxLength: 1000),
                        ContentDate = c.DateTime(nullable: false),
                        HeadingId = c.Int(nullable: false),
                        WriterId = c.Int(),
                    })
                .PrimaryKey(t => t.ContentId)
                .ForeignKey("dbo.Headings", t => t.HeadingId, cascadeDelete: true)
                .ForeignKey("dbo.Writers", t => t.WriterId)
                .Index(t => t.HeadingId)
                .Index(t => t.WriterId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContectId = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        UserMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 50),
                        Message = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ContectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "Category_CategoryId1", "dbo.Categories");
            DropForeignKey("dbo.Headings", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropForeignKey("dbo.Contents", "HeadingId", "dbo.Headings");
            DropForeignKey("dbo.Categories", "Heading_HeadingId", "dbo.Headings");
            DropForeignKey("dbo.Headings", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropIndex("dbo.Contents", new[] { "HeadingId" });
            DropIndex("dbo.Headings", new[] { "Category_CategoryId1" });
            DropIndex("dbo.Headings", new[] { "Category_CategoryId" });
            DropIndex("dbo.Headings", new[] { "WriterId" });
            DropIndex("dbo.Categories", new[] { "Heading_HeadingId" });
            DropTable("dbo.Contacts");
            DropTable("dbo.Contents");
            DropTable("dbo.Writers");
            DropTable("dbo.Headings");
            DropTable("dbo.Categories");
            DropTable("dbo.Abouts");
        }
    }
}
