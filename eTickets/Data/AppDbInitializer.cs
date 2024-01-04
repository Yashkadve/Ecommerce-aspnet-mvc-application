using eTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Database.ExecuteSqlRaw("INSERT INTO Cinemas (Name, Logo, Description) VALUES ('Cinema 1', 'http://dotnethow.net/images/cinemas/cinema-1.jpeg', 'This is the description of the first cinema')");
                    context.Database.ExecuteSqlRaw("INSERT INTO Cinemas (Name, Logo, Description) VALUES ('Cinema 2', 'http://dotnethow.net/images/cinemas/cinema-2.jpeg', 'This is the description of the second cinema')");
                    // Add more cinemas as needed

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Database.ExecuteSqlRaw("INSERT INTO Actors (FullName, Bio, ProfilePictureURL) VALUES ('Actor 1', 'This is the Bio of the first actor', 'http://dotnethow.net/images/actors/actor-1.jpeg')");
                    context.Database.ExecuteSqlRaw("INSERT INTO Actors (FullName, Bio, ProfilePictureURL) VALUES ('Actor 2', 'This is the Bio of the second actor', 'http://dotnethow.net/images/actors/actor-2.jpeg')");
                    // Add more actors as needed
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Database.ExecuteSqlRaw("INSERT INTO Producers (FullName, Bio, ProfilePictureURL) VALUES ('Producer 1', 'This is the Bio of the first producer', 'http://dotnethow.net/images/producers/producer-1.jpeg')");
                    context.Database.ExecuteSqlRaw("INSERT INTO Producers (FullName, Bio, ProfilePictureURL) VALUES ('Producer 2', 'This is the Bio of the second producer', 'http://dotnethow.net/images/producers/producer-2.jpeg')");
                    // Add more producers as needed
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Database.ExecuteSqlRaw("INSERT INTO Movies (Name, Description, Price, ImageURL, StartDate, EndDate, CinemaId, ProducerId, MovieCategory) VALUES ('Life', 'This is the Life movie description', 39.50, 'http://dotnethow.net/images/movies/movie-3.jpeg', GETDATE(), DATEADD(day, 10, GETDATE()),5,31,'Documentary')");
                    context.Database.ExecuteSqlRaw("INSERT INTO Movies (Name, Description, Price, ImageURL, StartDate, EndDate, CinemaId, ProducerId, MovieCategory) VALUES ('The Shawshank Redemption', 'This is the Shawshank Redemption description', 29.50, 'http://dotnethow.net/images/movies/movie-1.jpeg', GETDATE(), DATEADD(day, 3, GETDATE()),6,32,'Action')");
                    // Add more movies as needed
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Database.ExecuteSqlRaw("INSERT INTO Actors_Movies (ActorId, MovieId) VALUES (5,20)");
                    context.Database.ExecuteSqlRaw("INSERT INTO Actors_Movies (ActorId, MovieId) VALUES (6,21)");
                    // Add more actor-movie relationships as needed
                }
            }
        }
    }
}
