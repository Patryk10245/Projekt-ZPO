namespace Projekt_ZPO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewGames = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGames
            // 
            dataGridViewGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGames.Dock = DockStyle.Fill;
            dataGridViewGames.Location = new Point(0, 0);
            dataGridViewGames.Name = "dataGridViewGames";
            dataGridViewGames.Size = new Size(284, 261);
            dataGridViewGames.TabIndex = 0;
            dataGridViewGames.CellContentClick += dataGridViewGames_CellContentClick;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(dataGridViewGames);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridViewGames;
    }
}
