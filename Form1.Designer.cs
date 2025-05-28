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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewGames = new DataGridView();
            panel1 = new Panel();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnRemoveGame = new FontAwesome.Sharp.IconButton();
            btnAddGame = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            label1 = new Label();
            label2 = new Label();
            titlePanel = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).BeginInit();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewGames
            // 
            dataGridViewGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGames.BackgroundColor = Color.LightGray;
            dataGridViewGames.BorderStyle = BorderStyle.None;
            dataGridViewGames.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGames.Location = new Point(51, 252);
            dataGridViewGames.Name = "dataGridViewGames";
            dataGridViewGames.RowHeadersVisible = false;
            dataGridViewGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGames.ShowCellErrors = false;
            dataGridViewGames.ShowCellToolTips = false;
            dataGridViewGames.ShowEditingIcon = false;
            dataGridViewGames.ShowRowErrors = false;
            dataGridViewGames.Size = new Size(687, 266);
            dataGridViewGames.TabIndex = 0;
            dataGridViewGames.CellContentClick += dataGridViewGames_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnRemoveGame);
            panel1.Controls.Add(btnAddGame);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 559);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14F);
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.JediOrder;
            btnUpdate.IconColor = Color.Silver;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 32;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(0, 196);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(10, 0, 0, 0);
            btnUpdate.Size = new Size(200, 60);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnRemoveGame
            // 
            btnRemoveGame.Dock = DockStyle.Top;
            btnRemoveGame.FlatAppearance.BorderSize = 0;
            btnRemoveGame.FlatStyle = FlatStyle.Flat;
            btnRemoveGame.Font = new Font("Segoe UI", 14F);
            btnRemoveGame.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnRemoveGame.IconColor = Color.Silver;
            btnRemoveGame.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemoveGame.IconSize = 32;
            btnRemoveGame.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoveGame.Location = new Point(0, 136);
            btnRemoveGame.Name = "btnRemoveGame";
            btnRemoveGame.Padding = new Padding(10, 0, 0, 0);
            btnRemoveGame.Size = new Size(200, 60);
            btnRemoveGame.TabIndex = 8;
            btnRemoveGame.Text = "Remove Game";
            btnRemoveGame.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveGame.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveGame.UseVisualStyleBackColor = true;
            btnRemoveGame.Click += btnRemoveGame_Click_1;
            // 
            // btnAddGame
            // 
            btnAddGame.Dock = DockStyle.Top;
            btnAddGame.FlatAppearance.BorderSize = 0;
            btnAddGame.FlatStyle = FlatStyle.Flat;
            btnAddGame.Font = new Font("Segoe UI", 14F);
            btnAddGame.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddGame.IconColor = Color.Silver;
            btnAddGame.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddGame.IconSize = 32;
            btnAddGame.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddGame.Location = new Point(0, 76);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Padding = new Padding(10, 0, 0, 0);
            btnAddGame.Size = new Size(200, 60);
            btnAddGame.TabIndex = 7;
            btnAddGame.Text = "Add Game";
            btnAddGame.TextAlign = ContentAlignment.MiddleLeft;
            btnAddGame.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 76);
            panelLogo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 4;
            label1.Text = "GAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 5;
            label2.Text = "COLLECTION";
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.SlateBlue;
            titlePanel.Controls.Add(btnExit);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(200, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(810, 76);
            titlePanel.TabIndex = 5;

            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 76);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(810, 483);
            mainPanel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1010, 559);
            Controls.Add(mainPanel);
            Controls.Add(titlePanel);
            Controls.Add(panel1);
            Controls.Add(dataGridViewGames);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).EndInit();
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            titlePanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridViewGames;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAddGame;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnRemoveGame;
        private Panel titlePanel;
        private Panel mainPanel;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}
