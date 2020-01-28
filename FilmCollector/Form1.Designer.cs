namespace FilmCollector
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormats = new System.Windows.Forms.Label();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSourceFolder = new System.Windows.Forms.Button();
            this.fbdSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.lblMoviesFoundCount = new System.Windows.Forms.Label();
            this.bgwSearch = new System.ComponentModel.BackgroundWorker();
            this.prgSearch = new System.Windows.Forms.ProgressBar();
            this.lblSearching = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenres = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bgwSort = new System.ComponentModel.BackgroundWorker();
            this.prgSort = new System.Windows.Forms.ProgressBar();
            this.lblSorting = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnEditGenres = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.bgwCopy = new System.ComponentModel.BackgroundWorker();
            this.prgCopy = new System.Windows.Forms.ProgressBar();
            this.lblCopying = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDeleteSource = new System.Windows.Forms.CheckBox();
            this.tlpFormats = new System.Windows.Forms.TableLayoutPanel();
            this.chkFormats7 = new System.Windows.Forms.CheckBox();
            this.chkFormats6 = new System.Windows.Forms.CheckBox();
            this.chkFormats4 = new System.Windows.Forms.CheckBox();
            this.chkFormats3 = new System.Windows.Forms.CheckBox();
            this.chkFormats1 = new System.Windows.Forms.CheckBox();
            this.chkFormats2 = new System.Windows.Forms.CheckBox();
            this.chkFormats5 = new System.Windows.Forms.CheckBox();
            this.fbdDestinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.dgvDrives = new System.Windows.Forms.DataGridView();
            this.txtCustomFormat = new System.Windows.Forms.TextBox();
            this.lblCustomFormat = new System.Windows.Forms.Label();
            this.chkDeleteTitle = new System.Windows.Forms.CheckBox();
            this.btnTitles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.tlpFormats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrives)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormats
            // 
            this.lblFormats.AutoSize = true;
            this.lblFormats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormats.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFormats.Location = new System.Drawing.Point(74, 24);
            this.lblFormats.Name = "lblFormats";
            this.lblFormats.Size = new System.Drawing.Size(53, 15);
            this.lblFormats.TabIndex = 1;
            this.lblFormats.Text = "Formats:";
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(74, 71);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(73, 13);
            this.lblSourceFolder.TabIndex = 2;
            this.lblSourceFolder.Text = "Source folder:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSourceFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourceFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceFolder.Location = new System.Drawing.Point(77, 87);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(288, 23);
            this.txtSourceFolder.TabIndex = 3;
            this.txtSourceFolder.Enter += new System.EventHandler(this.txtSourceFolder_Enter);
            // 
            // btnBrowseSourceFolder
            // 
            this.btnBrowseSourceFolder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBrowseSourceFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseSourceFolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseSourceFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseSourceFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBrowseSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSourceFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSourceFolder.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseSourceFolder.Location = new System.Drawing.Point(77, 116);
            this.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder";
            this.btnBrowseSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSourceFolder.TabIndex = 1;
            this.btnBrowseSourceFolder.Text = "Browse";
            this.btnBrowseSourceFolder.UseVisualStyleBackColor = false;
            this.btnBrowseSourceFolder.Click += new System.EventHandler(this.btnBrowseSourceFolder_Click);
            // 
            // fbdSourceFolder
            // 
            this.fbdSourceFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(371, 234);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 43);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMovies.ColumnHeadersHeight = 33;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovies.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMovies.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMovies.Location = new System.Drawing.Point(77, 313);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvMovies.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMovies.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dgvMovies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovies.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvMovies.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvMovies.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvMovies.RowTemplate.Height = 33;
            this.dgvMovies.RowTemplate.ReadOnly = true;
            this.dgvMovies.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.Size = new System.Drawing.Size(288, 247);
            this.dgvMovies.TabIndex = 7;
            // 
            // lblMoviesFoundCount
            // 
            this.lblMoviesFoundCount.AutoSize = true;
            this.lblMoviesFoundCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoviesFoundCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMoviesFoundCount.Location = new System.Drawing.Point(158, 295);
            this.lblMoviesFoundCount.Name = "lblMoviesFoundCount";
            this.lblMoviesFoundCount.Size = new System.Drawing.Size(14, 15);
            this.lblMoviesFoundCount.TabIndex = 9;
            this.lblMoviesFoundCount.Text = "0";
            // 
            // bgwSearch
            // 
            this.bgwSearch.WorkerReportsProgress = true;
            this.bgwSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSearch_DoWork);
            this.bgwSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSearch_ProgressChanged);
            this.bgwSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSearch_RunWorkerCompleted);
            // 
            // prgSearch
            // 
            this.prgSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prgSearch.Enabled = false;
            this.prgSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.prgSearch.Location = new System.Drawing.Point(77, 583);
            this.prgSearch.MarqueeAnimationSpeed = 25;
            this.prgSearch.Name = "prgSearch";
            this.prgSearch.Size = new System.Drawing.Size(288, 23);
            this.prgSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSearch.TabIndex = 10;
            this.prgSearch.Visible = false;
            // 
            // lblSearching
            // 
            this.lblSearching.AutoSize = true;
            this.lblSearching.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearching.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearching.Location = new System.Drawing.Point(74, 613);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(128, 15);
            this.lblSearching.TabIndex = 11;
            this.lblSearching.Text = "Searching for movies...";
            this.lblSearching.Visible = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSort.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSort.Location = new System.Drawing.Point(371, 283);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(93, 43);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGenres.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGenres.ColumnHeadersHeight = 33;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnGenres});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGenres.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvGenres.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvGenres.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvGenres.Location = new System.Drawing.Point(470, 167);
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.RowHeadersVisible = false;
            this.dgvGenres.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dgvGenres.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGenres.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvGenres.RowTemplate.Height = 33;
            this.dgvGenres.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGenres.Size = new System.Drawing.Size(293, 393);
            this.dgvGenres.TabIndex = 13;
            this.dgvGenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenres_CellContentClick);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Width = 52;
            // 
            // ColumnGenres
            // 
            this.ColumnGenres.HeaderText = "Genres";
            this.ColumnGenres.Name = "ColumnGenres";
            this.ColumnGenres.Width = 47;
            // 
            // bgwSort
            // 
            this.bgwSort.WorkerReportsProgress = true;
            this.bgwSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSort_DoWork);
            this.bgwSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSort_ProgressChanged);
            this.bgwSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSort_RunWorkerCompleted);
            // 
            // prgSort
            // 
            this.prgSort.Location = new System.Drawing.Point(470, 583);
            this.prgSort.Name = "prgSort";
            this.prgSort.Size = new System.Drawing.Size(293, 23);
            this.prgSort.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgSort.TabIndex = 14;
            this.prgSort.Visible = false;
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorting.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSorting.Location = new System.Drawing.Point(467, 613);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(160, 15);
            this.lblSorting.TabIndex = 15;
            this.lblSorting.Text = "Determining genres by title...";
            this.lblSorting.Visible = false;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddGenre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddGenre.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.ForeColor = System.Drawing.Color.Black;
            this.btnAddGenre.Location = new System.Drawing.Point(632, 116);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 16;
            this.btnAddGenre.Text = "Populate genres";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnEditGenres
            // 
            this.btnEditGenres.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditGenres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditGenres.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditGenres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditGenres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGenres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGenres.ForeColor = System.Drawing.Color.Black;
            this.btnEditGenres.Location = new System.Drawing.Point(470, 116);
            this.btnEditGenres.Name = "btnEditGenres";
            this.btnEditGenres.Size = new System.Drawing.Size(75, 23);
            this.btnEditGenres.TabIndex = 17;
            this.btnEditGenres.Text = "Edit genres";
            this.btnEditGenres.UseVisualStyleBackColor = false;
            this.btnEditGenres.Click += new System.EventHandler(this.btnEditGenres_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCopy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopy.Location = new System.Drawing.Point(371, 332);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(93, 43);
            this.btnCopy.TabIndex = 18;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // bgwCopy
            // 
            this.bgwCopy.WorkerReportsProgress = true;
            this.bgwCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCopy_DoWork);
            this.bgwCopy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCopy_ProgressChanged);
            this.bgwCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCopy_RunWorkerCompleted);
            // 
            // prgCopy
            // 
            this.prgCopy.Location = new System.Drawing.Point(77, 640);
            this.prgCopy.MarqueeAnimationSpeed = 25;
            this.prgCopy.Name = "prgCopy";
            this.prgCopy.Size = new System.Drawing.Size(686, 23);
            this.prgCopy.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgCopy.TabIndex = 19;
            this.prgCopy.Visible = false;
            // 
            // lblCopying
            // 
            this.lblCopying.AutoSize = true;
            this.lblCopying.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopying.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCopying.Location = new System.Drawing.Point(77, 666);
            this.lblCopying.Name = "lblCopying";
            this.lblCopying.Size = new System.Drawing.Size(122, 15);
            this.lblCopying.TabIndex = 20;
            this.lblCopying.Text = "Copying in progress...";
            this.lblCopying.Visible = false;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddMovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Black;
            this.btnAddMovie.Location = new System.Drawing.Point(551, 116);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 22;
            this.btnAddMovie.Text = "Add movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source folder of the selected drive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Movies found:";
            // 
            // chkDeleteSource
            // 
            this.chkDeleteSource.AutoSize = true;
            this.chkDeleteSource.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteSource.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDeleteSource.Location = new System.Drawing.Point(371, 381);
            this.chkDeleteSource.Name = "chkDeleteSource";
            this.chkDeleteSource.Size = new System.Drawing.Size(97, 19);
            this.chkDeleteSource.TabIndex = 21;
            this.chkDeleteSource.Text = "Delete source";
            this.chkDeleteSource.UseVisualStyleBackColor = true;
            // 
            // tlpFormats
            // 
            this.tlpFormats.ColumnCount = 7;
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpFormats.Controls.Add(this.chkFormats7, 6, 0);
            this.tlpFormats.Controls.Add(this.chkFormats6, 0, 0);
            this.tlpFormats.Controls.Add(this.chkFormats4, 1, 0);
            this.tlpFormats.Controls.Add(this.chkFormats3, 5, 0);
            this.tlpFormats.Controls.Add(this.chkFormats1, 4, 0);
            this.tlpFormats.Controls.Add(this.chkFormats2, 3, 0);
            this.tlpFormats.Controls.Add(this.chkFormats5, 2, 0);
            this.tlpFormats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpFormats.ForeColor = System.Drawing.SystemColors.Control;
            this.tlpFormats.Location = new System.Drawing.Point(77, 42);
            this.tlpFormats.Name = "tlpFormats";
            this.tlpFormats.RowCount = 1;
            this.tlpFormats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormats.Size = new System.Drawing.Size(457, 26);
            this.tlpFormats.TabIndex = 23;
            // 
            // chkFormats7
            // 
            this.chkFormats7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats7.AutoSize = true;
            this.chkFormats7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats7.FlatAppearance.BorderSize = 0;
            this.chkFormats7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats7.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats7.Location = new System.Drawing.Point(393, 3);
            this.chkFormats7.Name = "chkFormats7";
            this.chkFormats7.Size = new System.Drawing.Size(61, 20);
            this.chkFormats7.TabIndex = 27;
            this.chkFormats7.Text = ".ext";
            this.chkFormats7.UseVisualStyleBackColor = true;
            // 
            // chkFormats6
            // 
            this.chkFormats6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats6.AutoSize = true;
            this.chkFormats6.Checked = true;
            this.chkFormats6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFormats6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats6.FlatAppearance.BorderSize = 0;
            this.chkFormats6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats6.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats6.Location = new System.Drawing.Point(3, 3);
            this.chkFormats6.Name = "chkFormats6";
            this.chkFormats6.Size = new System.Drawing.Size(59, 20);
            this.chkFormats6.TabIndex = 6;
            this.chkFormats6.Text = ".ext";
            this.chkFormats6.UseVisualStyleBackColor = true;
            // 
            // chkFormats4
            // 
            this.chkFormats4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats4.AutoSize = true;
            this.chkFormats4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats4.FlatAppearance.BorderSize = 0;
            this.chkFormats4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats4.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats4.Location = new System.Drawing.Point(68, 3);
            this.chkFormats4.Name = "chkFormats4";
            this.chkFormats4.Size = new System.Drawing.Size(59, 20);
            this.chkFormats4.TabIndex = 4;
            this.chkFormats4.Text = ".ext";
            this.chkFormats4.UseVisualStyleBackColor = true;
            // 
            // chkFormats3
            // 
            this.chkFormats3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats3.AutoSize = true;
            this.chkFormats3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats3.FlatAppearance.BorderSize = 0;
            this.chkFormats3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats3.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats3.Location = new System.Drawing.Point(328, 3);
            this.chkFormats3.Name = "chkFormats3";
            this.chkFormats3.Size = new System.Drawing.Size(59, 20);
            this.chkFormats3.TabIndex = 3;
            this.chkFormats3.Text = ".ext";
            this.chkFormats3.UseVisualStyleBackColor = true;
            // 
            // chkFormats1
            // 
            this.chkFormats1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats1.AutoSize = true;
            this.chkFormats1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats1.FlatAppearance.BorderSize = 0;
            this.chkFormats1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats1.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats1.Location = new System.Drawing.Point(263, 3);
            this.chkFormats1.Name = "chkFormats1";
            this.chkFormats1.Size = new System.Drawing.Size(59, 20);
            this.chkFormats1.TabIndex = 1;
            this.chkFormats1.Text = ".ext";
            this.chkFormats1.UseVisualStyleBackColor = true;
            // 
            // chkFormats2
            // 
            this.chkFormats2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats2.AutoSize = true;
            this.chkFormats2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats2.FlatAppearance.BorderSize = 0;
            this.chkFormats2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats2.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats2.Location = new System.Drawing.Point(198, 3);
            this.chkFormats2.Name = "chkFormats2";
            this.chkFormats2.Size = new System.Drawing.Size(59, 20);
            this.chkFormats2.TabIndex = 2;
            this.chkFormats2.Text = ".ext";
            this.chkFormats2.UseVisualStyleBackColor = true;
            // 
            // chkFormats5
            // 
            this.chkFormats5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFormats5.AutoSize = true;
            this.chkFormats5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkFormats5.FlatAppearance.BorderSize = 0;
            this.chkFormats5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkFormats5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFormats5.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFormats5.Location = new System.Drawing.Point(133, 3);
            this.chkFormats5.Name = "chkFormats5";
            this.chkFormats5.Size = new System.Drawing.Size(59, 20);
            this.chkFormats5.TabIndex = 5;
            this.chkFormats5.Text = ".ext";
            this.chkFormats5.UseVisualStyleBackColor = true;
            // 
            // fbdDestinationFolder
            // 
            this.fbdDestinationFolder.SelectedPath = "C:\\Film";
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDestinationFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinationFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDestinationFolder.Location = new System.Drawing.Point(470, 87);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(288, 23);
            this.txtDestinationFolder.TabIndex = 24;
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDestinationFolder.Location = new System.Drawing.Point(467, 71);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(104, 15);
            this.lblDestinationFolder.TabIndex = 25;
            this.lblDestinationFolder.Text = "Destination folder:";
            // 
            // dgvDrives
            // 
            this.dgvDrives.AllowUserToAddRows = false;
            this.dgvDrives.AllowUserToDeleteRows = false;
            this.dgvDrives.AllowUserToResizeRows = false;
            this.dgvDrives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrives.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDrives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrives.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDrives.ColumnHeadersHeight = 22;
            this.dgvDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrives.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDrives.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDrives.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDrives.Location = new System.Drawing.Point(77, 167);
            this.dgvDrives.Name = "dgvDrives";
            this.dgvDrives.RowHeadersVisible = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDrives.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDrives.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDrives.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDrives.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDrives.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvDrives.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDrives.RowTemplate.Height = 33;
            this.dgvDrives.RowTemplate.ReadOnly = true;
            this.dgvDrives.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrives.Size = new System.Drawing.Size(288, 110);
            this.dgvDrives.TabIndex = 26;
            this.dgvDrives.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrives_CellContentClick);
            this.dgvDrives.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrives_CellContentClick);
            // 
            // txtCustomFormat
            // 
            this.txtCustomFormat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCustomFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomFormat.Location = new System.Drawing.Point(693, 42);
            this.txtCustomFormat.Name = "txtCustomFormat";
            this.txtCustomFormat.Size = new System.Drawing.Size(65, 23);
            this.txtCustomFormat.TabIndex = 27;
            // 
            // lblCustomFormat
            // 
            this.lblCustomFormat.AutoSize = true;
            this.lblCustomFormat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomFormat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCustomFormat.Location = new System.Drawing.Point(596, 47);
            this.lblCustomFormat.Name = "lblCustomFormat";
            this.lblCustomFormat.Size = new System.Drawing.Size(91, 15);
            this.lblCustomFormat.TabIndex = 28;
            this.lblCustomFormat.Text = "Custom format:";
            // 
            // chkDeleteTitle
            // 
            this.chkDeleteTitle.AutoSize = true;
            this.chkDeleteTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDeleteTitle.Location = new System.Drawing.Point(371, 406);
            this.chkDeleteTitle.Name = "chkDeleteTitle";
            this.chkDeleteTitle.Size = new System.Drawing.Size(82, 19);
            this.chkDeleteTitle.TabIndex = 29;
            this.chkDeleteTitle.Text = "Delete title";
            this.chkDeleteTitle.UseVisualStyleBackColor = true;
            // 
            // btnTitles
            // 
            this.btnTitles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTitles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitles.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTitles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitles.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTitles.Location = new System.Drawing.Point(371, 453);
            this.btnTitles.Name = "btnTitles";
            this.btnTitles.Size = new System.Drawing.Size(93, 43);
            this.btnTitles.TabIndex = 30;
            this.btnTitles.Text = "Titles";
            this.btnTitles.UseVisualStyleBackColor = false;
            this.btnTitles.Click += new System.EventHandler(this.btnTitles_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(833, 691);
            this.Controls.Add(this.btnTitles);
            this.Controls.Add(this.chkDeleteTitle);
            this.Controls.Add(this.lblCustomFormat);
            this.Controls.Add(this.txtCustomFormat);
            this.Controls.Add(this.dgvDrives);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.tlpFormats);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.chkDeleteSource);
            this.Controls.Add(this.lblCopying);
            this.Controls.Add(this.prgCopy);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnEditGenres);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.lblSorting);
            this.Controls.Add(this.prgSort);
            this.Controls.Add(this.dgvGenres);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblSearching);
            this.Controls.Add(this.prgSearch);
            this.Controls.Add(this.lblMoviesFoundCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBrowseSourceFolder);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSourceFolder);
            this.Controls.Add(this.lblFormats);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(849, 612);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Collector";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.tlpFormats.ResumeLayout(false);
            this.tlpFormats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFormats;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnBrowseSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdSourceFolder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Label lblMoviesFoundCount;
        private System.ComponentModel.BackgroundWorker bgwSearch;
        private System.Windows.Forms.ProgressBar prgSearch;
        private System.Windows.Forms.Label lblSearching;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.ComponentModel.BackgroundWorker bgwSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnGenres;
        private System.Windows.Forms.ProgressBar prgSort;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnEditGenres;
        private System.Windows.Forms.Button btnCopy;
        private System.ComponentModel.BackgroundWorker bgwCopy;
        private System.Windows.Forms.ProgressBar prgCopy;
        private System.Windows.Forms.Label lblCopying;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDeleteSource;
        private System.Windows.Forms.TableLayoutPanel tlpFormats;
        private System.Windows.Forms.CheckBox chkFormats1;
        private System.Windows.Forms.CheckBox chkFormats6;
        private System.Windows.Forms.CheckBox chkFormats5;
        private System.Windows.Forms.CheckBox chkFormats4;
        private System.Windows.Forms.CheckBox chkFormats3;
        private System.Windows.Forms.CheckBox chkFormats2;
        private System.Windows.Forms.FolderBrowserDialog fbdDestinationFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.DataGridView dgvDrives;
        private System.Windows.Forms.CheckBox chkFormats7;
        private System.Windows.Forms.TextBox txtCustomFormat;
        private System.Windows.Forms.Label lblCustomFormat;
        private System.Windows.Forms.CheckBox chkDeleteTitle;
        private System.Windows.Forms.Button btnTitles;
    }
}

