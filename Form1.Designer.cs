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
            btnResetFilters = new FontAwesome.Sharp.IconButton();
            cmbPlatformFilter = new ComboBox();
            txtSearch = new TextBox();
            btnFilter = new FontAwesome.Sharp.IconButton();
            cmbGenreFilter = new ComboBox();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnRemoveGame = new FontAwesome.Sharp.IconButton();
            btnAddGame = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            label1 = new Label();
            label2 = new Label();
            titlePanel = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewGames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGames.Location = new Point(50, 253);
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
            panel1.Controls.Add(btnResetFilters);
            panel1.Controls.Add(cmbPlatformFilter);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(cmbGenreFilter);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnRemoveGame);
            panel1.Controls.Add(btnAddGame);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 588);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Anchor = AnchorStyles.Left;
            btnResetFilters.FlatAppearance.BorderSize = 0;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetFilters.IconChar = FontAwesome.Sharp.IconChar.JediOrder;
            btnResetFilters.IconColor = Color.Silver;
            btnResetFilters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResetFilters.IconSize = 32;
            btnResetFilters.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetFilters.Location = new Point(2, 411);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Padding = new Padding(10, 0, 0, 0);
            btnResetFilters.Size = new Size(200, 60);
            btnResetFilters.TabIndex = 14;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.TextAlign = ContentAlignment.MiddleLeft;
            btnResetFilters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // cmbPlatformFilter
            // 
            cmbPlatformFilter.FormattingEnabled = true;
            cmbPlatformFilter.Location = new Point(106, 371);
            cmbPlatformFilter.Name = "cmbPlatformFilter";
            cmbPlatformFilter.Size = new Size(76, 23);
            cmbPlatformFilter.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 263);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(171, 23);
            txtSearch.TabIndex = 11;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Left;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.IconChar = FontAwesome.Sharp.IconChar.JediOrder;
            btnFilter.IconColor = Color.Silver;
            btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFilter.IconSize = 32;
            btnFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilter.Location = new Point(2, 307);
            btnFilter.Name = "btnFilter";
            btnFilter.Padding = new Padding(10, 0, 0, 0);
            btnFilter.Size = new Size(200, 60);
            btnFilter.TabIndex = 11;
            btnFilter.Text = "Sort";
            btnFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbGenreFilter
            // 
            cmbGenreFilter.FormattingEnabled = true;
            cmbGenreFilter.Location = new Point(11, 371);
            cmbGenreFilter.Name = "cmbGenreFilter";
            cmbGenreFilter.Size = new Size(79, 23);
            cmbGenreFilter.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Top;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnRemoveGame.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveGame.IconChar = FontAwesome.Sharp.IconChar.Backspace;
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
            btnAddGame.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGame.IconChar = FontAwesome.Sharp.IconChar.Plus;
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
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 10);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 4;
            label1.Text = "GAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 47);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 5;
            label2.Text = "COLLECTION";
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.SlateBlue;
            titlePanel.Controls.Add(btnMinimize);
            titlePanel.Controls.Add(btnExit);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(200, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1227, 73);
            titlePanel.TabIndex = 5;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Black;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(1104, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(61, 23);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(1165, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(61, 23);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 73);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1227, 515);
            mainPanel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1427, 588);
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
            panel1.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btnMinimize;
        private TextBox txtSearch;
        private ComboBox cmbGenreFilter;
        private ComboBox cmbPlatformFilter;
        private FontAwesome.Sharp.IconButton btnFilter;
        private FontAwesome.Sharp.IconButton btnResetFilters;
    }
}
