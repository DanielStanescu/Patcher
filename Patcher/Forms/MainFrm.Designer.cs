namespace Patcher {
    partial class MainFrm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            SourceLbl = new Label();
            Source2Lbl = new Label();
            SourceBtn = new Button();
            SourceDlg = new FolderBrowserDialog();
            FilesLbl = new Label();
            FilesDgv = new DataGridView();
            FilesIdDgi = new DataGridViewTextBoxColumn();
            FilesPathDgi = new DataGridViewTextBoxColumn();
            FilesSizeDgi = new DataGridViewTextBoxColumn();
            FilesTypeDgi = new DataGridViewTextBoxColumn();
            MainPrg = new ProgressBar();
            ConfigsLbl = new Label();
            EntitiesLbl = new Label();
            ConfigsDgv = new DataGridView();
            ConfigsSelDvi = new DataGridViewCheckBoxColumn();
            ConfigsPathDgi = new DataGridViewTextBoxColumn();
            EntitiesDgv = new DataGridView();
            EntitiesSelDgi = new DataGridViewCheckBoxColumn();
            EntitiesPathDgi = new DataGridViewTextBoxColumn();
            RawBtn = new Button();
            ZipBtn = new Button();
            ZipDlg = new SaveFileDialog();
            RawDlg = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)FilesDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConfigsDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EntitiesDgv).BeginInit();
            SuspendLayout();
            // 
            // SourceLbl
            // 
            SourceLbl.BackColor = Color.FromArgb(77, 116, 150);
            SourceLbl.BorderStyle = BorderStyle.FixedSingle;
            SourceLbl.Location = new Point(10, 10);
            SourceLbl.Name = "SourceLbl";
            SourceLbl.Size = new Size(685, 23);
            SourceLbl.TabIndex = 0;
            SourceLbl.Text = "Source";
            SourceLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Source2Lbl
            // 
            Source2Lbl.BackColor = Color.White;
            Source2Lbl.BorderStyle = BorderStyle.FixedSingle;
            Source2Lbl.ForeColor = Color.Black;
            Source2Lbl.Location = new Point(10, 32);
            Source2Lbl.Name = "Source2Lbl";
            Source2Lbl.Size = new Size(720, 23);
            Source2Lbl.TabIndex = 1;
            Source2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SourceBtn
            // 
            SourceBtn.BackColor = SystemColors.Control;
            SourceBtn.Cursor = Cursors.Hand;
            SourceBtn.FlatStyle = FlatStyle.Flat;
            SourceBtn.ForeColor = Color.Black;
            SourceBtn.Location = new Point(694, 10);
            SourceBtn.Name = "SourceBtn";
            SourceBtn.Size = new Size(36, 23);
            SourceBtn.TabIndex = 0;
            SourceBtn.Text = "...";
            SourceBtn.UseVisualStyleBackColor = false;
            SourceBtn.Click += SourceBtn_Click;
            // 
            // FilesLbl
            // 
            FilesLbl.BackColor = Color.FromArgb(77, 116, 150);
            FilesLbl.BorderStyle = BorderStyle.FixedSingle;
            FilesLbl.Location = new Point(10, 65);
            FilesLbl.Name = "FilesLbl";
            FilesLbl.Size = new Size(720, 23);
            FilesLbl.TabIndex = 4;
            FilesLbl.Text = "Files (0)";
            FilesLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FilesDgv
            // 
            FilesDgv.AllowUserToAddRows = false;
            FilesDgv.AllowUserToDeleteRows = false;
            FilesDgv.AllowUserToResizeColumns = false;
            FilesDgv.AllowUserToResizeRows = false;
            FilesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FilesDgv.BackgroundColor = Color.Silver;
            FilesDgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            FilesDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FilesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FilesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            FilesDgv.Columns.AddRange(new DataGridViewColumn[] { FilesIdDgi, FilesPathDgi, FilesSizeDgi, FilesTypeDgi });
            FilesDgv.Cursor = Cursors.Hand;
            FilesDgv.EnableHeadersVisualStyles = false;
            FilesDgv.GridColor = Color.Silver;
            FilesDgv.Location = new Point(10, 87);
            FilesDgv.MultiSelect = false;
            FilesDgv.Name = "FilesDgv";
            FilesDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            FilesDgv.RowHeadersVisible = false;
            FilesDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            FilesDgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            FilesDgv.RowTemplate.Height = 20;
            FilesDgv.RowTemplate.Resizable = DataGridViewTriState.False;
            FilesDgv.ScrollBars = ScrollBars.Vertical;
            FilesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilesDgv.ShowCellErrors = false;
            FilesDgv.ShowCellToolTips = false;
            FilesDgv.ShowEditingIcon = false;
            FilesDgv.ShowRowErrors = false;
            FilesDgv.Size = new Size(720, 305);
            FilesDgv.TabIndex = 99;
            FilesDgv.TabStop = false;
            FilesDgv.RowsAdded += FilesDgv_RowsAdded;
            FilesDgv.RowsRemoved += FilesDgv_RowsRemoved;
            // 
            // FilesIdDgi
            // 
            FilesIdDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FilesIdDgi.FillWeight = 5F;
            FilesIdDgi.HeaderText = "Id";
            FilesIdDgi.MinimumWidth = 40;
            FilesIdDgi.Name = "FilesIdDgi";
            FilesIdDgi.ReadOnly = true;
            FilesIdDgi.Resizable = DataGridViewTriState.False;
            FilesIdDgi.SortMode = DataGridViewColumnSortMode.NotSortable;
            FilesIdDgi.Width = 40;
            // 
            // FilesPathDgi
            // 
            FilesPathDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FilesPathDgi.FillWeight = 85F;
            FilesPathDgi.HeaderText = "Path";
            FilesPathDgi.Name = "FilesPathDgi";
            FilesPathDgi.ReadOnly = true;
            FilesPathDgi.Resizable = DataGridViewTriState.False;
            FilesPathDgi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FilesSizeDgi
            // 
            FilesSizeDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FilesSizeDgi.FillWeight = 5F;
            FilesSizeDgi.HeaderText = "Size";
            FilesSizeDgi.MinimumWidth = 50;
            FilesSizeDgi.Name = "FilesSizeDgi";
            FilesSizeDgi.ReadOnly = true;
            FilesSizeDgi.Resizable = DataGridViewTriState.False;
            FilesSizeDgi.SortMode = DataGridViewColumnSortMode.NotSortable;
            FilesSizeDgi.Width = 50;
            // 
            // FilesTypeDgi
            // 
            FilesTypeDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FilesTypeDgi.FillWeight = 5F;
            FilesTypeDgi.HeaderText = "Type";
            FilesTypeDgi.MinimumWidth = 50;
            FilesTypeDgi.Name = "FilesTypeDgi";
            FilesTypeDgi.ReadOnly = true;
            FilesTypeDgi.Resizable = DataGridViewTriState.False;
            FilesTypeDgi.SortMode = DataGridViewColumnSortMode.NotSortable;
            FilesTypeDgi.Width = 50;
            // 
            // MainPrg
            // 
            MainPrg.Location = new Point(-1, 402);
            MainPrg.MarqueeAnimationSpeed = 15;
            MainPrg.Name = "MainPrg";
            MainPrg.Size = new Size(992, 8);
            MainPrg.TabIndex = 6;
            // 
            // ConfigsLbl
            // 
            ConfigsLbl.BackColor = Color.FromArgb(77, 116, 150);
            ConfigsLbl.BorderStyle = BorderStyle.FixedSingle;
            ConfigsLbl.Location = new Point(740, 65);
            ConfigsLbl.Name = "ConfigsLbl";
            ConfigsLbl.Size = new Size(240, 23);
            ConfigsLbl.TabIndex = 12;
            ConfigsLbl.Text = "Configs (0)";
            ConfigsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EntitiesLbl
            // 
            EntitiesLbl.BackColor = Color.FromArgb(77, 116, 150);
            EntitiesLbl.BorderStyle = BorderStyle.FixedSingle;
            EntitiesLbl.Location = new Point(740, 262);
            EntitiesLbl.Name = "EntitiesLbl";
            EntitiesLbl.Size = new Size(240, 23);
            EntitiesLbl.TabIndex = 7;
            EntitiesLbl.Text = "Entities (0)";
            EntitiesLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfigsDgv
            // 
            ConfigsDgv.AllowUserToAddRows = false;
            ConfigsDgv.AllowUserToDeleteRows = false;
            ConfigsDgv.AllowUserToResizeColumns = false;
            ConfigsDgv.AllowUserToResizeRows = false;
            ConfigsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigsDgv.BackgroundColor = Color.Silver;
            ConfigsDgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            ConfigsDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ConfigsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ConfigsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ConfigsDgv.Columns.AddRange(new DataGridViewColumn[] { ConfigsSelDvi, ConfigsPathDgi });
            ConfigsDgv.Cursor = Cursors.Hand;
            ConfigsDgv.EnableHeadersVisualStyles = false;
            ConfigsDgv.GridColor = Color.Silver;
            ConfigsDgv.Location = new Point(740, 87);
            ConfigsDgv.MultiSelect = false;
            ConfigsDgv.Name = "ConfigsDgv";
            ConfigsDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ConfigsDgv.RowHeadersVisible = false;
            ConfigsDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            ConfigsDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ConfigsDgv.RowTemplate.Height = 20;
            ConfigsDgv.RowTemplate.Resizable = DataGridViewTriState.False;
            ConfigsDgv.ScrollBars = ScrollBars.Vertical;
            ConfigsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ConfigsDgv.ShowCellErrors = false;
            ConfigsDgv.ShowCellToolTips = false;
            ConfigsDgv.ShowEditingIcon = false;
            ConfigsDgv.ShowRowErrors = false;
            ConfigsDgv.Size = new Size(240, 165);
            ConfigsDgv.TabIndex = 99;
            ConfigsDgv.TabStop = false;
            ConfigsDgv.RowsAdded += ConfigsDgv_RowsAdded;
            ConfigsDgv.RowsRemoved += ConfigsDgv_RowsRemoved;
            // 
            // ConfigsSelDvi
            // 
            ConfigsSelDvi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ConfigsSelDvi.HeaderText = "";
            ConfigsSelDvi.MinimumWidth = 20;
            ConfigsSelDvi.Name = "ConfigsSelDvi";
            ConfigsSelDvi.Resizable = DataGridViewTriState.False;
            ConfigsSelDvi.Width = 20;
            // 
            // ConfigsPathDgi
            // 
            ConfigsPathDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ConfigsPathDgi.HeaderText = "Path";
            ConfigsPathDgi.MinimumWidth = 50;
            ConfigsPathDgi.Name = "ConfigsPathDgi";
            ConfigsPathDgi.ReadOnly = true;
            ConfigsPathDgi.Resizable = DataGridViewTriState.False;
            ConfigsPathDgi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // EntitiesDgv
            // 
            EntitiesDgv.AllowUserToAddRows = false;
            EntitiesDgv.AllowUserToDeleteRows = false;
            EntitiesDgv.AllowUserToResizeColumns = false;
            EntitiesDgv.AllowUserToResizeRows = false;
            EntitiesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EntitiesDgv.BackgroundColor = Color.Silver;
            EntitiesDgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            EntitiesDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            EntitiesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            EntitiesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EntitiesDgv.Columns.AddRange(new DataGridViewColumn[] { EntitiesSelDgi, EntitiesPathDgi });
            EntitiesDgv.Cursor = Cursors.Hand;
            EntitiesDgv.EnableHeadersVisualStyles = false;
            EntitiesDgv.GridColor = Color.Silver;
            EntitiesDgv.Location = new Point(740, 284);
            EntitiesDgv.MultiSelect = false;
            EntitiesDgv.Name = "EntitiesDgv";
            EntitiesDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            EntitiesDgv.RowHeadersVisible = false;
            EntitiesDgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            EntitiesDgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            EntitiesDgv.RowTemplate.Height = 20;
            EntitiesDgv.RowTemplate.Resizable = DataGridViewTriState.False;
            EntitiesDgv.ScrollBars = ScrollBars.Vertical;
            EntitiesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EntitiesDgv.ShowCellErrors = false;
            EntitiesDgv.ShowCellToolTips = false;
            EntitiesDgv.ShowEditingIcon = false;
            EntitiesDgv.ShowRowErrors = false;
            EntitiesDgv.Size = new Size(240, 108);
            EntitiesDgv.TabIndex = 99;
            EntitiesDgv.TabStop = false;
            EntitiesDgv.RowsAdded += EntitiesDgv_RowsAdded;
            EntitiesDgv.RowsRemoved += EntitiesDgv_RowsRemoved;
            // 
            // EntitiesSelDgi
            // 
            EntitiesSelDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            EntitiesSelDgi.HeaderText = "";
            EntitiesSelDgi.MinimumWidth = 20;
            EntitiesSelDgi.Name = "EntitiesSelDgi";
            EntitiesSelDgi.Resizable = DataGridViewTriState.False;
            EntitiesSelDgi.Width = 20;
            // 
            // EntitiesPathDgi
            // 
            EntitiesPathDgi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EntitiesPathDgi.HeaderText = "Path";
            EntitiesPathDgi.MinimumWidth = 50;
            EntitiesPathDgi.Name = "EntitiesPathDgi";
            EntitiesPathDgi.ReadOnly = true;
            EntitiesPathDgi.Resizable = DataGridViewTriState.False;
            EntitiesPathDgi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // RawBtn
            // 
            RawBtn.BackColor = SystemColors.Control;
            RawBtn.Cursor = Cursors.Hand;
            RawBtn.FlatStyle = FlatStyle.Flat;
            RawBtn.ForeColor = Color.Black;
            RawBtn.Location = new Point(791, 10);
            RawBtn.Name = "RawBtn";
            RawBtn.Size = new Size(68, 45);
            RawBtn.TabIndex = 1;
            RawBtn.Text = "Raw";
            RawBtn.UseVisualStyleBackColor = false;
            RawBtn.Click += RawBtn_Click;
            // 
            // ZipBtn
            // 
            ZipBtn.BackColor = SystemColors.Control;
            ZipBtn.Cursor = Cursors.Hand;
            ZipBtn.FlatStyle = FlatStyle.Flat;
            ZipBtn.ForeColor = Color.Black;
            ZipBtn.Location = new Point(858, 10);
            ZipBtn.Name = "ZipBtn";
            ZipBtn.Size = new Size(68, 45);
            ZipBtn.TabIndex = 2;
            ZipBtn.Text = "Zip";
            ZipBtn.UseVisualStyleBackColor = false;
            ZipBtn.Click += ZipBtn_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(990, 409);
            Controls.Add(ZipBtn);
            Controls.Add(RawBtn);
            Controls.Add(EntitiesDgv);
            Controls.Add(ConfigsDgv);
            Controls.Add(ConfigsLbl);
            Controls.Add(EntitiesLbl);
            Controls.Add(MainPrg);
            Controls.Add(FilesDgv);
            Controls.Add(FilesLbl);
            Controls.Add(SourceBtn);
            Controls.Add(Source2Lbl);
            Controls.Add(SourceLbl);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(1006, 448);
            MinimumSize = new Size(1006, 448);
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patcher © LeanSoft.ro";
            FormClosing += MainFrm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)FilesDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConfigsDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)EntitiesDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label SourceLbl;
        private Label Source2Lbl;
        private Button SourceBtn;
        private FolderBrowserDialog SourceDlg;
        private Label FilesLbl;
        private DataGridView FilesDgv;
        private ProgressBar MainPrg;
        private Label EntitiesLbl;
        private Label ConfigsLbl;
        private Label label2;
        private DataGridView ConfigsDgv;
        private DataGridView EntitiesDgv;
        private Button RawBtn;
        private Button ZipBtn;
        private DataGridViewCheckBoxColumn EntitiesSelDgi;
        private DataGridViewTextBoxColumn EntitiesPathDgi;
        private DataGridViewTextBoxColumn FilesIdDgi;
        private DataGridViewTextBoxColumn FilesPathDgi;
        private DataGridViewTextBoxColumn FilesSizeDgi;
        private DataGridViewTextBoxColumn FilesTypeDgi;
        private DataGridViewCheckBoxColumn ConfigsSelDvi;
        private DataGridViewTextBoxColumn ConfigsPathDgi;
        private SaveFileDialog ZipDlg;
        private FolderBrowserDialog RawDlg;
    }
}