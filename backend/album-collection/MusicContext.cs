using album_collection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
    

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist()
                {
                    Id = 1,
                    Name = "Dream Theater",
                    Image = "DreamTheater.jpg"
                },

                new Artist()
                {
                    Id = 2,
                    Name = "Nipsey Hussle",
                    Image = "NipseyHussle.png"
                },

                new Artist()
                {
                    Id = 3,
                    Name = "Big Sean",
                    Image = "BigSean.jpg"
                },

                new Artist()
                {
                    Id = 4,
                    Name = "The Band",
                    Image = "TheBand.png"
                },

                new Artist()
                {
                    Id = 5,
                    Name = "The Beach Boys",
                    Image = "TheBeachBoys.jpg"
                });

            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 1,
                    Name = "Metropolis Pt.2: Scenes from a Memory",
                    Image = "ScenesFromAMemory.jpg",
                    Description = "The fifth studio album and first concept album by American progressive metal band Dream Theater, released on October 26, 1999 through Elektra Records.",
                    Rating = "10",
                    PopularTrack = "Fatal Tragedy",
                    ArtistId = 1,
                },

                new Album()
                {
                    Id = 2,
                    Name = "Distance over Time",
                    Image = "DistanceOverTime.png",
                    Description = "The fourteenth studio album by American progressive metal band Dream Theater, released on February 22, 2019, and being the band's first release on Inside Out Music.",
                    Rating = "9",
                    PopularTrack = "S2N",
                    ArtistId = 1,
                },

                 new Album()
                 {
                     Id = 3,
                     Name = "Victory Lap",
                     Image = "VictoryLap.png",
                     Description = "The debut and only studio album by American rapper Nipsey Hussle.",
                     Rating = "10",
                     PopularTrack = "Victory Lap",
                     ArtistId = 2,
                 },

                 new Album()
                 {
                     Id = 4,
                     Name = "I Decided",
                     Image = "IDecided.jpg",
                     Description = "The fourth studio album by American rapper Big Sean. It was released on February 3, 2017, through GOOD Music and distributed by Def Jam Recordings.",
                     Rating = "7.5",
                     PopularTrack = "Bigger Than Me",
                     ArtistId = 3,
                 },

                 new Album()
                 {
                     Id = 5,
                     Name = "Music from Big Pink",
                     Image = "BigPink.jpg",
                     Description = "The debut studio album by the Band. Released in 1968, it employs a distinctive blend of country, rock, folk, classical, R&B, blues, and soul.",
                     Rating = "10",
                     PopularTrack = "The Weight",
                     ArtistId = 4,
                 },

                 new Album()
                 {
                     Id = 6,
                     Name = "Pet Sounds",
                     Image = "PetSounds.jpg",
                     Description = "The 11th studio album by the American rock band the Beach Boys, released May 16, 1966 on Capitol Records.",
                     Rating = "11",
                     PopularTrack = "Wouldn't It Be Nice",
                     ArtistId = 5,
                 }); 

        }
    }
}
