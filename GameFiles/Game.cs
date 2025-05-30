using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ZPO
{
    public abstract class Game
    {
        public string Title { get; set; }
        public string Platform { get; set; }
        public int ReleaseDate { get; set; }
        public string Description { get; set; }
        public double PlayTime { get; set; }
        public double UserRating { get; set; }
        public GenreType Genre { get; set; }
        public bool IsCompleted { get; set; }

        //public Game(string title, 
        //    GenreType genre, 
        //    string platform, 
        //    int releaseDate, 
        //    string description, 
        //    double playTime, 
        //    double userRating, 
        //    bool IsCompleted)
        //{

        //    Title = title;
        //    Genre = genre;
        //    Platform = platform;
        //    ReleaseDate = releaseDate;
        //    PlayTime = Math.Max(playTime, 0);
        //    UserRating = Math.Clamp(userRating, 0, 10);
        //    Description = description;
        //    this.IsCompleted = IsCompleted;


        //}
        public enum GenreType
        {
            Action,
            Adventure,
            RPG,
            Simulation,
            Strategy,
            Sports,
            Puzzle,
            Horror,
            Racing,
            Survival,
            Fighting
        }

        public enum PlatformType
        {
            PC,
            PS4,
            PS5,
            XBOX_ONE,
            XBOX_SERIES_X,
            SWITCH
        }
        public abstract string GetGameDetails();

    }
}
