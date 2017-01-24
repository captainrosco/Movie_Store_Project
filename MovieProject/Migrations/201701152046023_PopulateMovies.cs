namespace MovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, Stock, ReleaseDate, DateAdded) Values ('Shrek', 'Comedy', 4, '1.4.2005', '1.15.2005') ");
            Sql("INSERT INTO Movies (Name, Genre, Stock, ReleaseDate, DateAdded) Values ('Friday 13', 'Horror', 2, '4.4.1988', '10.15.2001') ");
            Sql("INSERT INTO Movies (Name, Genre, Stock, ReleaseDate, DateAdded) Values ('Party Time', 'Comedy', 5, '1.4.2010', '1.15.2011') ");
            Sql("INSERT INTO Movies (Name, Genre, Stock, ReleaseDate, DateAdded) Values ('I Am Legend', 'Drama', 1, '1.4.2001', '1.15.2003') ");
        }
        
        public override void Down()
        {
        }
    }
}
