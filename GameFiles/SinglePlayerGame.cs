using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ZPO
{
    internal class SinglePlayerGame : Game
    {
        public bool HasStoryMode { get; set; }

        public SinglePlayerGame(string title,
            GenreType genre,
            string platform,
            int releaseDate,
            string description,
            double playTime,
            double userRating,
            bool isCompleted,
            bool hasStoryMode)
        {
            Title = title;
            Genre = genre;
            Platform = platform;
            ReleaseDate = releaseDate;
            PlayTime = Math.Max(playTime, 0);
            UserRating = Math.Clamp(userRating, 0, 10);
            Description = description;
            IsCompleted = isCompleted;
            HasStoryMode = hasStoryMode;
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
                   $"Has Story Mode: {HasStoryMode}";
        }

    }
}
