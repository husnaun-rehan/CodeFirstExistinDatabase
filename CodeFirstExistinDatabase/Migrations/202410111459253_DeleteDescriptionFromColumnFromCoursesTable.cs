﻿namespace CodeFirstExistinDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDescriptionFromColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Description", c => c.String());
        }
    }
}
