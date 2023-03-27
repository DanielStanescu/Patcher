using Microsoft.VisualBasic;
using System.IO.Compression;

namespace Patcher {

    public partial class MainFrm : Form {

        private Thread? thread;

        public MainFrm() {
            InitializeComponent();
        }

        private void SourceBtn_Click(object sender, EventArgs e) {
            try {
                SourceDlg.Reset();
                SourceDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + Path.DirectorySeparatorChar + @"PhpstormProjects" + Path.DirectorySeparatorChar;
                if (SourceDlg.ShowDialog() == DialogResult.OK) {
                    if (Directory.Exists(SourceDlg.SelectedPath) == true) {
                        thread = new Thread(SourceThread);
                        thread.Start();
                    }
                }
            } catch (Exception) {
                MessageBox.Show("Error getting Files.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SourceThread() {
            string path;

            this.Invoke(() => {
                Source2Lbl.Text = SourceDlg.SelectedPath;
                SourceBtn.Enabled = false;
                RawBtn.Enabled = false;
                ZipBtn.Enabled = false;
                FilesDgv.Rows.Clear();
                FilesDgv.Enabled = false;
                ConfigsDgv.Rows.Clear();
                ConfigsDgv.Enabled = false;
                EntitiesDgv.Rows.Clear();
                EntitiesDgv.Enabled = false;
                MainPrg.Style = ProgressBarStyle.Marquee;
            });

            Thread.Sleep(1000);

            foreach (FileSystemInfo item in new DirectoryInfo(SourceDlg.SelectedPath).GetFileSystemInfos("*", SearchOption.AllDirectories)) {
                path = item.FullName[(SourceDlg.SelectedPath.Length + 1)..];

                if (path.Equals(@".git") == true || path.StartsWith(@".git" + Path.DirectorySeparatorChar) == true || path.EndsWith(Path.DirectorySeparatorChar + @".git") == true || path.Contains(Path.DirectorySeparatorChar + @".git" + Path.DirectorySeparatorChar) == true) {
                } else if (path.Equals(@".gitkeep") == true || path.EndsWith(Path.DirectorySeparatorChar + @".gitkeep") == true) {
                } else if (path.Equals(@".gitignore") == true || path.EndsWith(Path.DirectorySeparatorChar + @".gitignore") == true) {
                } else if (path.Equals(@".idea") == true || path.StartsWith(@".idea" + Path.DirectorySeparatorChar) == true || path.EndsWith(Path.DirectorySeparatorChar + @".idea") == true || path.Contains(Path.DirectorySeparatorChar + @".idea" + Path.DirectorySeparatorChar) == true) {
                } else if (path.Equals(@"files") == true || path.StartsWith(@"files" + Path.DirectorySeparatorChar) == true) {
                } else if (path.Equals(@"logs") == true || path.StartsWith(@"logs" + Path.DirectorySeparatorChar) == true) {
                } else if (path.Equals(@"packager.exe") == true || path.Equals(@"packager.json") == true) {
                } else {
                    try {
                        if (item.Attributes.HasFlag(FileAttributes.Directory) == true) {
                            this.Invoke(() => {
                                FilesDgv.Rows.Add((FilesDgv.Rows.Count + 1).ToString(), path, "0", "dir");
                            });
                        } else if (path.Equals(@"configs" + Path.DirectorySeparatorChar + @"site.php") == true || path.StartsWith(@"configs" + Path.DirectorySeparatorChar + @"stages" + Path.DirectorySeparatorChar) == true) {
                            this.Invoke(() => {
                                ConfigsDgv.Rows.Add(false, path);
                            });
                        } else if (path.StartsWith(@"entities" + Path.DirectorySeparatorChar) == true && path.EndsWith(Path.DirectorySeparatorChar + @"config.php") == true) {
                            this.Invoke(() => {
                                EntitiesDgv.Rows.Add(path.Contains(Path.DirectorySeparatorChar + @"customer" + Path.DirectorySeparatorChar) != true, path);
                            });
                        } else {
                            this.Invoke(() => {
                                FilesDgv.Rows.Add((FilesDgv.Rows.Count + 1).ToString(), path, ((FileInfo)item).Length, item.Extension);
                            });
                        }
                    } catch (Exception) {
                        MessageBox.Show("Error parsing Source files.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }

            this.Invoke(() => {
                SourceBtn.Enabled = true;
                RawBtn.Enabled = true;
                ZipBtn.Enabled = true;
                FilesDgv.Enabled = true;
                ConfigsDgv.Enabled = true;
                EntitiesDgv.Enabled = true;
                MainPrg.Style = ProgressBarStyle.Continuous;
            });
        }

        private void RawBtn_Click(object sender, EventArgs e) {
            try {
                SourceDlg.Reset();
                RawDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar;
                if (RawDlg.ShowDialog() == DialogResult.OK) {
                    if (Directory.Exists(RawDlg.SelectedPath + Path.DirectorySeparatorChar + @"files") == true) {
                        MessageBox.Show("Destination already contains a 'files' directory.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        thread = new Thread(RawThread);
                        thread.Start();
                    }
                }
            } catch (Exception) {
                MessageBox.Show("Error creating Raw.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RawThread() {
            this.Invoke(() => {
                SourceBtn.Enabled = false;
                RawBtn.Enabled = false;
                ZipBtn.Enabled = false;
                FilesDgv.Enabled = false;
                ConfigsDgv.Enabled = false;
                EntitiesDgv.Enabled = false;
                MainPrg.Style = ProgressBarStyle.Marquee;
            });

            Thread.Sleep(1000);

            try {
                Directory.CreateDirectory(RawDlg.SelectedPath + Path.DirectorySeparatorChar + @"files");
                foreach (DataGridViewRow row in FilesDgv.Rows) {
                    if (row.Cells[3].Value.Equals("dir") == true) Directory.CreateDirectory(RawDlg.SelectedPath + Path.DirectorySeparatorChar + @"files" + Path.DirectorySeparatorChar + row.Cells[1].Value);
                }
                foreach (DataGridViewRow row in FilesDgv.Rows) {
                    if (row.Cells[3].Value.Equals("dir") == false) File.Copy(SourceDlg.SelectedPath + Path.DirectorySeparatorChar + row.Cells[1].Value, RawDlg.SelectedPath + Path.DirectorySeparatorChar + @"files" + System.IO.Path.DirectorySeparatorChar + row.Cells[1].Value);
                }
                foreach (DataGridViewRow row in ConfigsDgv.Rows) {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true) File.Copy(SourceDlg.SelectedPath + Path.DirectorySeparatorChar + row.Cells[1].Value, RawDlg.SelectedPath + Path.DirectorySeparatorChar + @"files" + System.IO.Path.DirectorySeparatorChar + row.Cells[1].Value);
                }
                foreach (DataGridViewRow row in EntitiesDgv.Rows) {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true) File.Copy(SourceDlg.SelectedPath + Path.DirectorySeparatorChar + row.Cells[1].Value, RawDlg.SelectedPath + Path.DirectorySeparatorChar + @"files" + System.IO.Path.DirectorySeparatorChar + row.Cells[1].Value);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error writting Raw." + ex.Message, Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Invoke(() => {
                SourceBtn.Enabled = true;
                RawBtn.Enabled = true;
                ZipBtn.Enabled = true;
                FilesDgv.Enabled = true;
                ConfigsDgv.Enabled = true;
                EntitiesDgv.Enabled = true;
                MainPrg.Style = ProgressBarStyle.Continuous;

                MessageBox.Show("Raw created, job done!", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void ZipBtn_Click(object sender, EventArgs e) {
            try {
                ZipDlg.Reset();
                ZipDlg.DefaultExt = "zip";
                ZipDlg.FileName = "files";
                ZipDlg.Filter = "Zip Files (*.zip)|*.zip";
                ZipDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar;
                if (ZipDlg.ShowDialog() == DialogResult.OK) {
                    if (File.Exists(ZipDlg.FileName) == true) {
                        MessageBox.Show("Destination already contains a 'files' archive.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        thread = new Thread(ZipThread);
                        thread.Start();
                    }
                }
            } catch (Exception) {
                MessageBox.Show("Error creating Zip.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZipThread() {
            this.Invoke(() => {
                SourceBtn.Enabled = false;
                RawBtn.Enabled = false;
                ZipBtn.Enabled = false;
                FilesDgv.Enabled = false;
                ConfigsDgv.Enabled = false;
                EntitiesDgv.Enabled = false;
                MainPrg.Style = ProgressBarStyle.Marquee;
            });

            Thread.Sleep(1000);

            try {
                using System.IO.Compression.ZipArchive zip = System.IO.Compression.ZipFile.Open(ZipDlg.FileName, System.IO.Compression.ZipArchiveMode.Create);

                foreach (DataGridViewRow row in FilesDgv.Rows) {
                    if (row.Cells[3].Value.Equals("dir") == true) zip.CreateEntry(row.Cells[1].Value.ToString() + Path.DirectorySeparatorChar);
                }
                foreach (DataGridViewRow row in FilesDgv.Rows) {
                    if (row.Cells[3].Value.Equals("dir") == false) zip.CreateEntryFromFile(SourceDlg.SelectedPath + Path.DirectorySeparatorChar + row.Cells[1].Value, row.Cells[1].Value + "");
                }
                foreach (DataGridViewRow row in ConfigsDgv.Rows) {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true) zip.CreateEntryFromFile(SourceDlg.SelectedPath + Path.DirectorySeparatorChar + row.Cells[1].Value, row.Cells[1].Value + "");
                }
                foreach (DataGridViewRow row in EntitiesDgv.Rows) {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true) zip.CreateEntryFromFile(SourceDlg.SelectedPath + Path.DirectorySeparatorChar + row.Cells[1].Value, row.Cells[1].Value + "");
                }
            } catch (Exception ex) {
                MessageBox.Show("Error writting Zip.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Invoke(() => {
                SourceBtn.Enabled = true;
                RawBtn.Enabled = true;
                ZipBtn.Enabled = true;
                FilesDgv.Enabled = true;
                ConfigsDgv.Enabled = true;
                EntitiesDgv.Enabled = true;
                MainPrg.Style = ProgressBarStyle.Continuous;

                MessageBox.Show("Zip created, job done!", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void FilesDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            FilesLbl.Text = "Files (" + FilesDgv.Rows.Count + ")";
        }

        private void FilesDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            FilesLbl.Text = "Files (" + FilesDgv.Rows.Count + ")";
        }

        private void ConfigsDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            FilesLbl.Text = "Configs (" + ConfigsDgv.Rows.Count + ")";
        }

        private void ConfigsDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            FilesLbl.Text = "Configs (" + ConfigsDgv.Rows.Count + ")";
        }

        private void EntitiesDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            FilesLbl.Text = "Entities (" + EntitiesDgv.Rows.Count + ")";
        }

        private void EntitiesDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            FilesLbl.Text = "Entities (" + EntitiesDgv.Rows.Count + ")";
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) {
            if (thread != null && thread.IsAlive == true) {
                e.Cancel = true;

                MessageBox.Show("Can't close now, app is working.", Config.name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (MessageBox.Show("Sure you want to close?", Config.name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }

}