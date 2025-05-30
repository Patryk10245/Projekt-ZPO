using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameClass = Projekt_ZPO.Game;
namespace Projekt_ZPO
{
    public partial class AddGameForm : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GameClass NewGame { get; set; }
        public event EventHandler<Game> GameAdded;
        public event EventHandler<Game> Cancel;
        public event EventHandler<Game> GameUpdated;
        public AddGameForm()
        {
            InitializeComponent();

            cmbGenre.DataSource = Enum.GetValues(typeof(Game.GenreType));
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatform.DataSource = Enum.GetValues(typeof(Game.PlatformType));
            cmbPlatform.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public AddGameForm(Game editGame)
        {
            InitializeComponent();

            cmbGenre.DataSource = Enum.GetValues(typeof(Game.GenreType));
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatform.DataSource = Enum.GetValues(typeof(Game.PlatformType));
            cmbPlatform.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTitle.Text = editGame.Title;
            cmbPlatform.Text = editGame.Platform;
            cmbGenre.SelectedItem = editGame.Genre;
            txtReleaseDate.Text = editGame.ReleaseDate.ToString();
            txtPlayTime.Text = editGame.PlayTime.ToString();
            cmbRating.Text = editGame.UserRating.ToString();
            txtReview.Text = editGame.Description;
            chkCompleted.Checked = editGame.IsCompleted;
            chkSinglePlayer.Checked = editGame is SinglePlayerGame;
            chkCooperative.Checked = editGame is CooperativeGame;

        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string platform = cmbPlatform.Text;
                var genre = (Game.GenreType)cmbGenre.SelectedItem;
                int releaseDate = int.Parse(txtReleaseDate.Text);
                double playtime = double.Parse(txtPlayTime.Text);
                double userRating = double.Parse(cmbRating.Text);
                string review = txtReview.Text;
                bool IsCompleted = chkCompleted.Checked;
                bool hasStoryMode = chkSinglePlayer.Checked;
                bool hasCooperativeMode = chkCooperative.Checked;

                if (chkSinglePlayer.Checked)
                {
                    NewGame = new SinglePlayerGame(title, genre, platform, releaseDate, review, playtime, userRating, IsCompleted, hasStoryMode);
                }
                else if (chkCooperative.Checked)
                {
                    NewGame = new CooperativeGame(title, genre, platform, releaseDate, review, playtime, userRating, IsCompleted, hasCooperativeMode);
                }
                else
                {
                    throw new Exception("Please select a game type (Single Player or Cooperative).");
                }
                GameAdded?.Invoke(this, NewGame);
                GameUpdated?.Invoke(this, NewGame);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wypełnij wszystkie pola poprawnie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Cancel?.Invoke(this, NewGame);
        }

        private void chkSinglePlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinglePlayer.Checked)
            {
                chkCooperative.Visible = false;
            }
            else
            {
                chkCooperative.Visible = true;
            }
        }

        private void chkCooperative_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCooperative.Checked)
            {
                chkSinglePlayer.Visible = false;
            }
            else
            {
                chkSinglePlayer.Visible = true;
            }
        }
    }
}
