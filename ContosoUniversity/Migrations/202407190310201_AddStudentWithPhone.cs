namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentWithPhone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "PhoneNumber", c => c.String(maxLength: 50));
        }
    }
}
