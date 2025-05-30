using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ZPO
{
    internal class CooperativeGame : Game
    {
        //public int MaxPlayers { get; set; }
        public bool HasCooperativeMode { get; set; }
        public CooperativeGame(string title,
            GenreType genre,
            string platform,
            int releaseDate,
            string description,
            double playTime,
            double userRating,
            bool isCompleted,
            bool hasCooperativeMode)
        {
            Title = title;
            Genre = genre;
            Platform = platform;
            ReleaseDate = releaseDate;
            PlayTime = Math.Max(playTime, 0);
            UserRating = Math.Clamp(userRating, 0, 10);
            Description = description;
            IsCompleted = isCompleted;
            //MaxPlayers = maxPlayers;
            HasCooperativeMode = hasCooperativeMode;
        }
        public override string GetGameDetails()
        {
            return $"Title: {Title}\n" +
                   $"Genre: {Genre}\n" +
                   $"Platform: {Platform}\n" +
                   $"Release Date: {ReleaseDate}\n" +
                   $"Description: {Description}\n" +
                   $"Play Time: {PlayTime} hours\n" +
                   $"User Rating: {UserRating}/10\n" +
                   $"Is Completed: {IsCompleted}\n" +
                   $"Requires Online Connection: {HasCooperativeMode}";
        }
    }
   
}
