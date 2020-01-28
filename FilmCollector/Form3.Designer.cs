namespace FilmCollector
{
    partial class Form3
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
            this.lblAddingNewMovie = new System.Windows.Forms.Label();
            this.txtPrimaryTitle = new System.Windows.Forms.TextBox();
            this.lblPrimaryTitle = new System.Windows.Forms.Label();
            this.lblOriginalTitle = new System.Windows.Forms.Label();
            this.txtOriginalTitle = new System.Windows.Forms.TextBox();
            this.nudStartyear = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.txtGenres = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartyear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddingNewMovie
            // 
            this.lblAddingNewMovie.AutoSize = true;
            this.lblAddingNewMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingNewMovie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddingNewMovie.Location = new System.Drawing.Point(12, 9);
            this.lblAddingNewMovie.Name = "lblAddingNewMovie";
            this.lblAddingNewMovie.Size = new System.Drawing.Size(110, 15);
            this.lblAddingNewMovie.TabIndex = 0;
            this.lblAddingNewMovie.Text = "Adding new movie:";
            // 
            // txtPrimaryTitle
            // 
            this.txtPrimaryTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrimaryTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimaryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimaryTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPrimaryTitle.Location = new System.Drawing.Point(15, 64);
            this.txtPrimaryTitle.Name = "txtPrimaryTitle";
            this.txtPrimaryTitle.Size = new System.Drawing.Size(233, 23);
            this.txtPrimaryTitle.TabIndex = 1;
            // 
            // lblPrimaryTitle
            // 
            this.lblPrimaryTitle.AutoSize = true;
            this.lblPrimaryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrimaryTitle.Location = new System.Drawing.Point(12, 48);
            this.lblPrimaryTitle.Name = "lblPrimaryTitle";
            this.lblPrimaryTitle.Size = new System.Drawing.Size(74, 15);
            this.lblPrimaryTitle.TabIndex = 2;
            this.lblPrimaryTitle.Text = "Primary title:";
            // 
            // lblOriginalTitle
            // 
            this.lblOriginalTitle.AutoSize = true;
            this.lblOriginalTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOriginalTitle.Location = new System.Drawing.Point(12, 96);
            this.lblOriginalTitle.Name = "lblOriginalTitle";
            this.lblOriginalTitle.Size = new System.Drawing.Size(75, 15);
            this.lblOriginalTitle.TabIndex = 4;
            this.lblOriginalTitle.Text = "Original title:";
            // 
            // txtOriginalTitle
            // 
            this.txtOriginalTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOriginalTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOriginalTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.txtOriginalTitle.Location = new System.Drawing.Point(15, 112);
            this.txtOriginalTitle.Name = "txtOriginalTitle";
            this.txtOriginalTitle.Size = new System.Drawing.Size(233, 23);
            this.txtOriginalTitle.TabIndex = 3;
            // 
            // nudStartyear
            // 
            this.nudStartyear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nudStartyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStartyear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStartyear.ForeColor = System.Drawing.SystemColors.Control;
            this.nudStartyear.Location = new System.Drawing.Point(15, 162);
            this.nudStartyear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudStartyear.Minimum = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            this.nudStartyear.Name = "nudStartyear";
            this.nudStartyear.Size = new System.Drawing.Size(120, 23);
            this.nudStartyear.TabIndex = 5;
            this.nudStartyear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(12, 146);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 15);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year:";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGenres.Location = new System.Drawing.Point(12, 192);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(46, 15);
            this.lblGenres.TabIndex = 8;
            this.lblGenres.Text = "Genres:";
            // 
            // txtGenres
            // 
            this.txtGenres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGenres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenres.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenres.ForeColor = System.Drawing.SystemColors.Control;
            this.txtGenres.Location = new System.Drawing.Point(15, 208);
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.Size = new System.Drawing.Size(233, 23);
            this.txtGenres.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdd.Location = new System.Drawing.Point(15, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancel.Location = new System.Drawing.Point(96, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(264, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.txtGenres);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.nudStartyear);
            this.Controls.Add(this.lblOriginalTitle);
            this.Controls.Add(this.txtOriginalTitle);
            this.Controls.Add(this.lblPrimaryTitle);
            this.Controls.Add(this.txtPrimaryTitle);
            this.Controls.Add(this.lblAddingNewMovie);
            this.MaximumSize = new System.Drawing.Size(280, 342);
            this.MinimumSize = new System.Drawing.Size(280, 342);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adding new movie";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddingNewMovie;
        private System.Windows.Forms.TextBox txtPrimaryTitle;
        private System.Windows.Forms.Label lblPrimaryTitle;
        private System.Windows.Forms.Label lblOriginalTitle;
        private System.Windows.Forms.TextBox txtOriginalTitle;
        private System.Windows.Forms.NumericUpDown nudStartyear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}