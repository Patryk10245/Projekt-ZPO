namespace Projekt_ZPO
{
    partial class AddGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            txtTitle = new TextBox();
            lblGenre = new Label();
            cmbGenre = new ComboBox();
            lblPlatform = new Label();
            cmbPlatform = new ComboBox();
            txtReleaseDate = new TextBox();
            lblDate = new Label();
            lblPlayTime = new Label();
            txtPlayTime = new TextBox();
            lblReview = new Label();
            txtReview = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtUserRating = new Label();
            cmbRating = new ComboBox();
            chkCompleted = new CheckBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(26, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(33, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Location = new Point(26, 40);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(382, 23);
            txtTitle.TabIndex = 1;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(26, 73);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(41, 15);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre:";
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(26, 91);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(121, 23);
            cmbGenre.TabIndex = 3;
            // 
            // lblPlatform
            // 
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(26, 124);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(56, 15);
            lblPlatform.TabIndex = 4;
            lblPlatform.Text = "Platform:";
            // 
            // cmbPlatform
            // 
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Location = new Point(26, 142);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(121, 23);
            cmbPlatform.TabIndex = 5;
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(175, 91);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(97, 23);
            txtReleaseDate.TabIndex = 6;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(175, 73);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(76, 15);
            lblDate.TabIndex = 7;
            lblDate.Text = "Release Date:";
            // 
            // lblPlayTime
            // 
            lblPlayTime.AutoSize = true;
            lblPlayTime.Location = new Point(175, 124);
            lblPlayTime.Name = "lblPlayTime";
            lblPlayTime.Size = new Size(62, 15);
            lblPlayTime.TabIndex = 8;
            lblPlayTime.Text = "Play Time:";
            // 
            // txtPlayTime
            // 
            txtPlayTime.Location = new Point(175, 142);
            txtPlayTime.Name = "txtPlayTime";
            txtPlayTime.Size = new Size(97, 23);
            txtPlayTime.TabIndex = 9;
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Location = new Point(26, 207);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(47, 15);
            lblReview.TabIndex = 10;
            lblReview.Text = "Review:";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(26, 225);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(260, 23);
            txtReview.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(47, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(175, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 37);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUserRating
            // 
            txtUserRating.AutoSize = true;
            txtUserRating.Location = new Point(26, 181);
            txtUserRating.Name = "txtUserRating";
            txtUserRating.Size = new Size(44, 15);
            txtUserRating.TabIndex = 14;
            txtUserRating.Text = "Rating:";
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(88, 178);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(47, 23);
            cmbRating.TabIndex = 15;
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.Location = new Point(318, 192);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(90, 19);
            chkCompleted.TabIndex = 16;
            chkCompleted.Text = "Completed?";
            chkCompleted.UseVisualStyleBackColor = true;
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkCompleted);
            Controls.Add(cmbRating);
            Controls.Add(txtUserRating);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReview);
            Controls.Add(lblReview);
            Controls.Add(txtPlayTime);
            Controls.Add(lblPlayTime);
            Controls.Add(lblDate);
            Controls.Add(txtReleaseDate);
            Controls.Add(cmbPlatform);
            Controls.Add(lblPlatform);
            Controls.Add(cmbGenre);
            Controls.Add(lblGenre);
            Controls.Add(txtTitle);
            Controls.Add(labelTitle);
            Name = "AddGameForm";
            Size = new Size(434, 339);
            Load += AddGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox txtTitle;
        private Label lblGenre;
        private ComboBox cmbGenre;
        private Label lblPlatform;
        private ComboBox cmbPlatform;
        private TextBox txtReleaseDate;
        private Label lblDate;
        private Label lblPlayTime;
        private TextBox txtPlayTime;
        private Label lblReview;
        private TextBox txtReview;
        private Button btnSave;
        private Button btnCancel;
        private Label txtUserRating;
        private ComboBox cmbRating;
        private CheckBox chkCompleted;
    }
}