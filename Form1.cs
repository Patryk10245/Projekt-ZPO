
using Newtonsoft.Json;
using Projekt_ZPO.Storage;
using Projekt_ZPO.LibraryManager;
using Projekt_ZPO.Interfaces;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Projekt_ZPO
{
    public partial class Form1 : Form
    {
        private ILibraryStorage storage;
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
            ShowGameList();
            titlePanel.MouseDown += titlePanel_MouseDown;

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
        private void ShowGameList()
        {
            mainPanel.Controls.Clear();
            dataGridViewGames.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dataGridViewGames);
            btnRemoveGame.Enabled = true;
            btnUpdate.Enabled = true;
            dataGridViewGames.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddGame_Click_1(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var gameControl = new AddGameForm();
            gameControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(gameControl);

            btnRemoveGame.Enabled = false;
            btnUpdate.Enabled = false;
            gameControl.GameAdded += (s, newGame) =>
            {
                try
                {
                    library.AddGame(newGame);
                    storage.SaveLibrary(library);

                    RefreshGameTable();
                    ShowGameList();
                }
                catch (GameAlreadyExistsException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            gameControl.Cancel += (s, e) =>
            {
                ShowGameList();

            };
        }

        private void btnRemoveGame_Click_1(object sender, EventArgs e)
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewGames.CurrentRow;
            var selectedGameTitle = selectedRow.Cells[0].Value.ToString();
            var editGame = library.Games.FirstOrDefault(g => g.Title == selectedGameTitle);

            if (selectedRow == null || editGame == null) return;
            var editGameForm = new AddGameForm(editGame);
            editGameForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(editGameForm);
            btnRemoveGame.Enabled = false;
            btnUpdate.Enabled = false;
            editGameForm.GameUpdated += (s, updatedGame) =>
            {
                try
                {
                    library.UpdateGame(editGame, editGameForm.NewGame);
                    RefreshGameTable();
                    storage.SaveLibrary(library);
                }
                catch (GameNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            editGameForm.Cancel += (s, e) =>
            {
                ShowGameList();
            };

        }


    }
}