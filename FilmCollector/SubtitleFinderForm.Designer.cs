namespace FilmCollector
{
    partial class SubtitleFinderForm
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
            this.components = new System.ComponentModel.Container();
            this.txtMovieLocation = new System.Windows.Forms.TextBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.ofdMovieLocation = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseMovie = new System.Windows.Forms.Button();
            this.btnPlayMovie = new System.Windows.Forms.Button();
            this.btnResync = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblTitles = new System.Windows.Forms.Label();
            this.btnTitlovi = new System.Windows.Forms.Button();
            this.chkDefaultSynchronizerLocation = new System.Windows.Forms.CheckBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblFps = new System.Windows.Forms.Label();
            this.lblFpsValue = new System.Windows.Forms.Label();
            this.rdbBalkan = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.lvwTitles = new System.Windows.Forms.ListView();
            this.Subtitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FPS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblExisting = new System.Windows.Forms.Label();
            this.lbxExisting = new System.Windows.Forms.ListBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.ttpPlayMovie = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtMovieLocation
            // 
            this.txtMovieLocation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMovieLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMovieLocation.Location = new System.Drawing.Point(91, 36);
            this.txtMovieLocation.Name = "txtMovieLocation";
            this.txtMovieLocation.Size = new System.Drawing.Size(351, 23);
            this.txtMovieLocation.TabIndex = 0;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMovie.Location = new System.Drawing.Point(15, 40);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(70, 15);
            this.lblMovie.TabIndex = 1;
            this.lblMovie.Text = "Movie path:";
            // 
            // ofdMovieLocation
            // 
            this.ofdMovieLocation.FileName = "openFileDialog1";
            // 
            // btnBrowseMovie
            // 
            this.btnBrowseMovie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBrowseMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseMovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseMovie.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseMovie.Location = new System.Drawing.Point(460, 36);
            this.btnBrowseMovie.Name = "btnBrowseMovie";
            this.btnBrowseMovie.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseMovie.TabIndex = 2;
            this.btnBrowseMovie.Text = "Browse...";
            this.btnBrowseMovie.UseVisualStyleBackColor = false;
            this.btnBrowseMovie.Click += new System.EventHandler(this.btnBrowseMovie_Click);
            // 
            // btnPlayMovie
            // 
            this.btnPlayMovie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlayMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayMovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayMovie.ForeColor = System.Drawing.Color.Black;
            this.btnPlayMovie.Location = new System.Drawing.Point(460, 515);
            this.btnPlayMovie.Name = "btnPlayMovie";
            this.btnPlayMovie.Size = new System.Drawing.Size(75, 23);
            this.btnPlayMovie.TabIndex = 4;
            this.btnPlayMovie.Text = "Play Movie";
            this.ttpPlayMovie.SetToolTip(this.btnPlayMovie, "Play movie with selected existing subtitles.");
            this.btnPlayMovie.UseVisualStyleBackColor = false;
            this.btnPlayMovie.Click += new System.EventHandler(this.btnPlayMovie_Click);
            // 
            // btnResync
            // 
            this.btnResync.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnResync.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResync.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResync.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResync.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResync.ForeColor = System.Drawing.Color.Black;
            this.btnResync.Location = new System.Drawing.Point(367, 515);
            this.btnResync.Name = "btnResync";
            this.btnResync.Size = new System.Drawing.Size(75, 23);
            this.btnResync.TabIndex = 5;
            this.btnResync.Text = "Resync";
            this.ttpPlayMovie.SetToolTip(this.btnResync, "Resync selected existing subtitle.");
            this.btnResync.UseVisualStyleBackColor = false;
            this.btnResync.Click += new System.EventHandler(this.btnResync_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTranslate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTranslate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTranslate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.Color.Black;
            this.btnTranslate.Location = new System.Drawing.Point(181, 515);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.ttpPlayMovie.SetToolTip(this.btnTranslate, "Translate selected existing subtitle.");
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblTitles
            // 
            this.lblTitles.AutoSize = true;
            this.lblTitles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitles.Location = new System.Drawing.Point(13, 287);
            this.lblTitles.Name = "lblTitles";
            this.lblTitles.Size = new System.Drawing.Size(72, 15);
            this.lblTitles.TabIndex = 7;
            this.lblTitles.Text = "Found titles:";
            // 
            // btnTitlovi
            // 
            this.btnTitlovi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTitlovi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitlovi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitlovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitlovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitlovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitlovi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitlovi.ForeColor = System.Drawing.Color.Black;
            this.btnTitlovi.Location = new System.Drawing.Point(447, 242);
            this.btnTitlovi.Name = "btnTitlovi";
            this.btnTitlovi.Size = new System.Drawing.Size(88, 23);
            this.btnTitlovi.TabIndex = 8;
            this.btnTitlovi.Text = "Titlovi.com";
            this.btnTitlovi.UseVisualStyleBackColor = false;
            this.btnTitlovi.Click += new System.EventHandler(this.btnTitlovi_Click);
            // 
            // chkDefaultSynchronizerLocation
            // 
            this.chkDefaultSynchronizerLocation.AutoSize = true;
            this.chkDefaultSynchronizerLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefaultSynchronizerLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDefaultSynchronizerLocation.Location = new System.Drawing.Point(88, 480);
            this.chkDefaultSynchronizerLocation.Name = "chkDefaultSynchronizerLocation";
            this.chkDefaultSynchronizerLocation.Size = new System.Drawing.Size(202, 19);
            this.chkDefaultSynchronizerLocation.TabIndex = 9;
            this.chkDefaultSynchronizerLocation.Text = "Use default Synchronizer location";
            this.chkDefaultSynchronizerLocation.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLanguage.Location = new System.Drawing.Point(23, 246);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(62, 15);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "Language:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(366, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDownload.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(88, 515);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.ttpPlayMovie.SetToolTip(this.btnDownload, "Download selected found subtitle.");
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFps.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFps.Location = new System.Drawing.Point(20, 206);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(65, 15);
            this.lblFps.TabIndex = 15;
            this.lblFps.Text = "Movie FPS:";
            // 
            // lblFpsValue
            // 
            this.lblFpsValue.AutoSize = true;
            this.lblFpsValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFpsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblFpsValue.Location = new System.Drawing.Point(86, 192);
            this.lblFpsValue.Name = "lblFpsValue";
            this.lblFpsValue.Size = new System.Drawing.Size(32, 37);
            this.lblFpsValue.TabIndex = 16;
            this.lblFpsValue.Text = "0";
            // 
            // rdbBalkan
            // 
            this.rdbBalkan.AutoSize = true;
            this.rdbBalkan.Checked = true;
            this.rdbBalkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBalkan.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbBalkan.Location = new System.Drawing.Point(91, 246);
            this.rdbBalkan.Name = "rdbBalkan";
            this.rdbBalkan.Size = new System.Drawing.Size(163, 19);
            this.rdbBalkan.TabIndex = 17;
            this.rdbBalkan.TabStop = true;
            this.rdbBalkan.Text = "Serbian, Croatian, Bosnian";
            this.rdbBalkan.UseVisualStyleBackColor = true;
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnglish.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbEnglish.Location = new System.Drawing.Point(257, 246);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(63, 19);
            this.rdbEnglish.TabIndex = 18;
            this.rdbEnglish.Text = "English";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            // 
            // lvwTitles
            // 
            this.lvwTitles.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lvwTitles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwTitles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subtitle,
            this.Language,
            this.FPS});
            this.lvwTitles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTitles.ForeColor = System.Drawing.SystemColors.Control;
            this.lvwTitles.FullRowSelect = true;
            this.lvwTitles.Location = new System.Drawing.Point(88, 282);
            this.lvwTitles.MultiSelect = false;
            this.lvwTitles.Name = "lvwTitles";
            this.lvwTitles.Size = new System.Drawing.Size(447, 155);
            this.lvwTitles.TabIndex = 19;
            this.lvwTitles.UseCompatibleStateImageBehavior = false;
            this.lvwTitles.View = System.Windows.Forms.View.Details;
            // 
            // Subtitle
            // 
            this.Subtitle.Text = "Subtitle";
            this.Subtitle.Width = 300;
            // 
            // Language
            // 
            this.Language.Text = "Language";
            this.Language.Width = 64;
            // 
            // FPS
            // 
            this.FPS.Text = "FPS";
            this.FPS.Width = 53;
            // 
            // lblExisting
            // 
            this.lblExisting.AutoSize = true;
            this.lblExisting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExisting.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExisting.Location = new System.Drawing.Point(35, 77);
            this.lblExisting.Name = "lblExisting";
            this.lblExisting.Size = new System.Drawing.Size(50, 15);
            this.lblExisting.TabIndex = 20;
            this.lblExisting.Text = "Existing:";
            // 
            // lbxExisting
            // 
            this.lbxExisting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbxExisting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxExisting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExisting.ForeColor = System.Drawing.SystemColors.Control;
            this.lbxExisting.FormattingEnabled = true;
            this.lbxExisting.ItemHeight = 15;
            this.lbxExisting.Location = new System.Drawing.Point(91, 77);
            this.lbxExisting.Name = "lbxExisting";
            this.lbxExisting.Size = new System.Drawing.Size(444, 92);
            this.lbxExisting.TabIndex = 21;
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTrim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrim.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrim.ForeColor = System.Drawing.Color.Black;
            this.btnTrim.Location = new System.Drawing.Point(274, 515);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(75, 23);
            this.btnTrim.TabIndex = 22;
            this.btnTrim.Text = "Trim";
            this.ttpPlayMovie.SetToolTip(this.btnTrim, "Trim selected existing subtitle.");
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // SubtitleFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(563, 566);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.lbxExisting);
            this.Controls.Add(this.lblExisting);
            this.Controls.Add(this.lvwTitles);
            this.Controls.Add(this.rdbEnglish);
            this.Controls.Add(this.rdbBalkan);
            this.Controls.Add(this.lblFpsValue);
            this.Controls.Add(this.lblFps);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.chkDefaultSynchronizerLocation);
            this.Controls.Add(this.btnTitlovi);
            this.Controls.Add(this.lblTitles);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnResync);
            this.Controls.Add(this.btnPlayMovie);
            this.Controls.Add(this.btnBrowseMovie);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.txtMovieLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubtitleFinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubtitleFinder";
            this.Activated += new System.EventHandler(this.SubtitleFinderForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovieLocation;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.OpenFileDialog ofdMovieLocation;
        private System.Windows.Forms.Button btnBrowseMovie;
        private System.Windows.Forms.Button btnPlayMovie;
        private System.Windows.Forms.Button btnResync;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblTitles;
        private System.Windows.Forms.Button btnTitlovi;
        private System.Windows.Forms.CheckBox chkDefaultSynchronizerLocation;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.Label lblFpsValue;
        private System.Windows.Forms.RadioButton rdbBalkan;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.ListView lvwTitles;
        private System.Windows.Forms.ColumnHeader Subtitle;
        private System.Windows.Forms.ColumnHeader Language;
        private System.Windows.Forms.ColumnHeader FPS;
        private System.Windows.Forms.Label lblExisting;
        private System.Windows.Forms.ListBox lbxExisting;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.ToolTip ttpPlayMovie;
    }
}