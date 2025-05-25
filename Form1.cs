
using Newtonsoft.Json;
using Projekt_ZPO.Storage;
using Projekt_ZPO.LibraryManager;

namespace Projekt_ZPO
{
    public partial class Form1 : Form
    {
        private LibraryStorage storage;
        private Library library = new Library();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            storage = new LibraryStorage();
            library = storage.LoadLibrary();
            RefreshGameTable();

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
                    storage.SaveLibrary(library);
                   
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
}