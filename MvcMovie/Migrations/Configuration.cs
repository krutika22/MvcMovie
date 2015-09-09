namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
             //   context.Movies.AddOrUpdate(
             //   c => c.Rating,
               // new Movie { Rating = "G" }
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
    //        );
            var movies = new List <Movie>{
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-1-11"),
                Genre = "Romantic Comedy",
                Rating = "PG",
                Price = 7.99M }
            };
            movies.ForEach(s => context.Movies.Add(s));
        }
    }
}
