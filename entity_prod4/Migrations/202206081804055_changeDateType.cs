﻿namespace entity_prod4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logs", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "Date", c => c.DateTime(nullable: false));
        }
    }
}
