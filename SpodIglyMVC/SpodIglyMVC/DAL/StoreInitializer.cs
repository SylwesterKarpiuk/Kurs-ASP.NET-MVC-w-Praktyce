﻿using SpodIglyMVC.Migrations;
using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.DAL
{
    public class StoreInitializer : MigrateDatabaseToLatestVersion<StoreContext, Configuration>
    {
        //protected override void Seed(StoreContext context)
        //{
        //    SeedStoreData(context);

        //    base.Seed(context);
        //}

        public static void SeedStoreData(StoreContext context)
        {
            var genres = new List<Genre> {
            new Genre() { GenreId=1, Name="Rock", IconFilename="rock.png"},
            new Genre() { GenreId=2, Name="Metal", IconFilename="metal.png"},
            new Genre() { GenreId=3, Name="Jazz", IconFilename="jazz.png"},
            new Genre() { GenreId=4, Name="Hip Hop", IconFilename="hiphop.png"},
            new Genre() { GenreId=5, Name="R&B", IconFilename="r&b.png"},
            new Genre() { GenreId=6, Name="Pop", IconFilename="pop.png"},
            new Genre() { GenreId=7, Name="Reggae", IconFilename="reggae.png"},
            new Genre() { GenreId=8, Name="Alternative", IconFilename="alternative.png"},
            new Genre() { GenreId=9, Name="Electronic", IconFilename="electronic.png"},
            new Genre() { GenreId=10, Name="Classical", IconFilename="classical.png"},
            new Genre() { GenreId=11, Name="Inne", IconFilename="inne.png"},
            new Genre() { GenreId=12, Name="Promocje", IconFilename="promocje.png"},
            };
            genres.ForEach(g => context.Genres.Add(g));
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album() { AlbumId = 1, ArtistName = "The Reds", AlbumTitle = "More Way", Price = 99, CoverFileName = "1.png", IsBestseller = true, DateAdded = new DateTime(2014, 02, 1), GenreId = 1 },
                new Album() { AlbumId = 2, ArtistName = "Dillusion", AlbumTitle = "All that nothing", Price = 54, CoverFileName = "2.png", IsBestseller = true, DateAdded = new DateTime(2013, 08, 15), GenreId = 1 },
                new Album() { AlbumId = 3, ArtistName = "Allfor", AlbumTitle = "Golden suffering", Price = 102, CoverFileName = "3.png", IsBestseller = true, DateAdded = new DateTime(2014, 01, 5), GenreId = 1 },
                new Album() { AlbumId = 4, ArtistName = "Stasik", AlbumTitle = "Pole samo się nie orze", Price = 25, CoverFileName = "4.jpg", IsBestseller = true, DateAdded = new DateTime(2014, 03, 11), GenreId = 1 },
                new Album() { AlbumId = 5, ArtistName = "McReal", AlbumTitle = "Illusion", Price = 28, CoverFileName = "5.png", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 1 },
                new Album() { AlbumId = 6, ArtistName = "The Punks", AlbumTitle = "Women Eater", Price = 30, CoverFileName = "6.png", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 1 },
                new Album() { AlbumId = 7, ArtistName = "EX Band", AlbumTitle = "What", Price = 35, CoverFileName = "7.png", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 2 },
                new Album() { AlbumId = 8, ArtistName = "Jamaican Cowboys", AlbumTitle = "IceTeam Quantanamera", Price = 21, CoverFileName = "8.png", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 2 },
                new Album() { AlbumId = 9, ArtistName = "Str8ts", AlbumTitle = "Sneakers Only", Price = 25, CoverFileName = "9.png", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 2 }
            };

            albums.ForEach(a => context.Albums.AddOrUpdate(a));
            context.SaveChanges();
        }
    }
}