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
            btnAddGame = new Button();
            btnRemoveGame = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGames
            // 
            dataGridViewGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGames.Location = new Point(0, 0);
            dataGridViewGames.Name = "dataGridViewGames";
            dataGridViewGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGames.Size = new Size(587, 208);
            dataGridViewGames.TabIndex = 0;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(22, 227);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(75, 23);
            btnAddGame.TabIndex = 1;
            btnAddGame.Text = "Add Game";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnRemoveGame
            // 
            btnRemoveGame.Location = new Point(22, 272);
            btnRemoveGame.Name = "btnRemoveGame";
            btnRemoveGame.Size = new Size(99, 23);
            btnRemoveGame.TabIndex = 2;
            btnRemoveGame.Text = "Remove Game";
            btnRemoveGame.UseVisualStyleBackColor = true;
            btnRemoveGame.Click += btnRemoveGame_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(142, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(588, 324);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemoveGame);
            Controls.Add(btnAddGame);
            Controls.Add(dataGridViewGames);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            ImeMode = ImeMode.NoControl;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridViewGames;
        private Button btnAddGame;
        private Button btnRemoveGame;
        private Button btnUpdate;
    }
}
