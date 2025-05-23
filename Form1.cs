

namespace Projekt_ZPO
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            library.AddGame(new Game("Minecraft", Game.GenreType.Survival, "PC", 2011, "Sandbox", 300, 9.5));
            library.AddGame(new Game("The Witcher 3", Game.GenreType.RPG, "PC", 2015, "Open World RPG", 100, 10));
            library.AddGame(new Game("FIFA 22", Game.GenreType.Sports, "PC", 2021, "Football Simulation", 50, 8.5));
            library.AddGame(new Game("Call of Duty", Game.GenreType.Action, "PC", 2003, "First-Person Shooter", 20, 9));
            library.AddGame(new Game("The Legend of Zelda: Breath of the Wild", Game.GenreType.Adventure, "Nintendo Switch", 2017, "Open World Adventure", 200, 10));

        }
        private Library library = new Library();
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGameTable();
        }

        private void dataGridViewGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshGameTable()
        {
            dataGridViewGames.DataSource = library.Games.Select(g => new
            {
                g.Title,
                g.Platform,
                g.ReleaseDate,
                g.Description,
                g.PlayTime,
                g.UserRating,
                Genre = g.Genre.ToString()
            }).ToList();
        }
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            var addGameForm = new AddGameForm();
            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    library.AddGame(addGameForm.NewGame);
                    RefreshGameTable();
                }
                catch (GameAlreadyExistsException ex)
                {
                    MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnRemoveGame_Click(object sender, EventArgs e)
        {
            if (dataGridViewGames.SelectedRows.Count == 0)
            {
                MessageBox.Show("No games selected to delete.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmRemove = MessageBox.Show(
                $"Are you sure to remove {dataGridViewGames.SelectedRows.Count} games?", 
                "Agreed", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            foreach (DataGridViewRow row in dataGridViewGames.SelectedRows)
            {
            Game removeGame = library.Games.FirstOrDefault(g => g.Title == dataGridViewGames.CurrentRow.Cells[0].Value.ToString());
            if (removeGame != null && confirmRemove == DialogResult.Yes)
            {
                try
                {
                    library.RemoveGame(removeGame);
                }
                catch (GameNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No games on list to delete.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshGameTable();
            }
        }
    }

    public class Game
    {
        public string Title { get; set; }

        public string Platform { get; set; }
        public int ReleaseDate { get; set; }
        public string Description { get; set; }
        public double PlayTime { get; set; }
        public double UserRating { get; set; }
        public GenreType Genre { get; set; }

        public Game(string title, GenreType genre, string platform, int releaseDate, string description, double playTime, double userRating)
        {

            this.Title = title;
            this.Genre = genre;
            this.Platform = platform;
            this.ReleaseDate = releaseDate;
            this.PlayTime = Math.Max(playTime, 0);
            this.UserRating = Math.Clamp(userRating, 0, 10);
            this.Description = description;

        }
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

    }
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
            if (index == -1)
            {
                Games[index] = newGame;
            }
            else
            {
                throw new GameNotFoundException(oldGame.Title);
            }
        }
        public List<Game> SearchByTitle(string title)
        {
            return Games.Where(g => g.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }

    public class GameAlreadyExistsException : Exception
    {
        public GameAlreadyExistsException(string title) : base($"Gra {title} ju¿ jest w bibliotece.") { }
    }
    public class GameNotFoundException : Exception
    {
        public GameNotFoundException(string title) : base($"Gra {title} nie zosta³a znaleziona w bibliotece.") { }
    }
    public class AppConfig
    { }

}