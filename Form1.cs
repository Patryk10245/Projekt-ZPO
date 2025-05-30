
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
            this.DoubleBuffered = true;


            cmbGenreFilter.DataSource = Enum.GetValues(typeof(Game.GenreType));
            cmbGenreFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatformFilter.DataSource = Enum.GetValues(typeof(Game.PlatformType));
            cmbPlatformFilter.DropDownStyle = ComboBoxStyle.DropDownList;


            cmbGenreFilter.SelectedIndex = -1;
            cmbPlatformFilter.SelectedIndex = -1;

            txtSearch.Text = "Search by title";
            cmbGenreFilter.Text = "Select Genre";
            cmbPlatformFilter.Text = "Select Platform";
        }
        private void RefreshGameTable()
        {
            dataGridViewGames.DataSource = library.Games.Select(g => new
            {
                g.Title,
                g.Platform,
                g.ReleaseDate,
                g.PlayTime,
                g.UserRating,
                Genre = g.Genre.ToString(),
                g.IsCompleted,
                Type = g is CooperativeGame ? "Co-op" : "Single",
                g.Description



            }).ToList();
        }
        private void ShowGameList()
        {
            mainPanel.Controls.Clear();
            dataGridViewGames.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dataGridViewGames);
            btnRemoveGame.Enabled = true;
            btnUpdate.Enabled = true;
            btnAddGame.Enabled = true;
            btnFilter.Enabled = true;
            btnResetFilters.Enabled = true;
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
            btnAddGame.Enabled = false;
            btnFilter.Enabled = false;
            btnResetFilters.Enabled = false;
            editGameForm.GameUpdated += (s, updatedGame) =>
            {
                try
                {
                    library.UpdateGame(editGame, updatedGame);
                    RefreshGameTable();
                    storage.SaveLibrary(library);
                    ShowGameList();
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
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            var filterGames = library.Games.AsEnumerable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                filterGames = filterGames.Where(g => g.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
            }
            if (cmbGenreFilter.SelectedIndex != -1)
            {
                var selectedGenre = (Game.GenreType)cmbGenreFilter.SelectedItem;
                filterGames = filterGames.Where(g => g.Genre == selectedGenre);
            }

            if (cmbPlatformFilter.SelectedIndex != -1)
            {
                var selectedPlatform = (Game.PlatformType)cmbPlatformFilter.SelectedItem;
                filterGames = filterGames.Where(g => g.Platform == selectedPlatform.ToString());
            }
            if (filterGames.Any())
            {
                dataGridViewGames.DataSource = filterGames.Select(g => new
                {
                    g.Title,
                    g.Platform,
                    g.ReleaseDate,
                    g.Description,
                    g.PlayTime,
                    g.UserRating,
                    Genre = g.Genre.ToString(),
                    g.IsCompleted,
                }).ToList();
            }
            else
            {
                MessageBox.Show("No games found matching the selected filters.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGameTable();

            }
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cmbGenreFilter.SelectedIndex = -1;
            cmbPlatformFilter.SelectedIndex = -1;
            RefreshGameTable();
            dataGridViewGames.ClearSelection();
        }


    }
}