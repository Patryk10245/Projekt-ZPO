using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ZPO.LibraryManager
{
    public class Library
    {
        public List<Game> Games { get; set; }
        public Library()
        {
            Games = new List<Game>();
        }
        public void AddGame(Game game)
        {
            
            if (Games.Any(g => g.Title == game.Title))
            {
                throw new GameAlreadyExistsException(game.Title);
            }
            Games.Add(game);
        }

        public void RemoveGame(Game game)
        {
            bool removed = Games.Remove(game);

            if (!removed)
            {
                throw new GameNotFoundException(game.Title);
            }
        }

        public void UpdateGame(Game oldGame, Game newGame)
        {
            var index = Games.FindIndex(g => g.Title == oldGame.Title);
            if (index != -1)
            {
                Games[index] = newGame;
            }
            else
            {
                throw new GameNotFoundException(oldGame.Title);
            }
        }

    }
}
