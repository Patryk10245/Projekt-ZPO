using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_ZPO;
namespace Projekt_ZPO
{
    public partial class AddGameForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Game NewGame { get; set; }
        public AddGameForm()
        {
            InitializeComponent();

            cmbGenre.DataSource = Enum.GetValues(typeof(Game.GenreType));
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatform.Items.AddRange(new string[] { "PC", "PS4", "PS5", "XBOX ONE", "XBOX SERIES X", "SWITCH" });
            cmbPlatform.DropDownStyle = ComboBoxStyle.DropDownList;

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

                NewGame = new Game(title, genre, platform, releaseDate, review, playtime, userRating);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wypełnij wszystkie pola poprawnie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
