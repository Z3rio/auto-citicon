using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Auto_Citicon
{
    public partial class Window : System.Windows.Forms.Form
    {
        public Window()
        {
            InitializeComponent();
            this.Resize += Window_Resize;
            this.MinimumSize = new System.Drawing.Size(600, 400);
        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {
            if (FileDialog.FileName != null && FileDialog.FileName != "" && FolderBrowser.SelectedPath != null && FolderBrowser.SelectedPath != "" && File.Exists(FileDialog.FileName) && Directory.Exists(FolderBrowser.SelectedPath))
            {
                DirectoryInfo directory = new DirectoryInfo(FolderBrowser.SelectedPath);
                FileInfo[] ydrFiles = directory.GetFiles("*.ydr");

                if (ydrFiles.Length > 0)
                {
                    FileInfo citiconFile = new FileInfo(FileDialog.FileName);
                    if (citiconFile.Name == "CitiCon.com")
                    {
                        Progress.Value = 0;
                        Progress.Maximum = ydrFiles.Length;
                        Label.Text = "Converting files";

                        for (int i = 0; i < ydrFiles.Length; i++)
                        {
                            FileInfo file = ydrFiles[i];
                            string cmdCommand = $"/C {citiconFile.FullName} formats:convert {file.FullName}";

                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "cmd.exe";
                            startInfo.Arguments = cmdCommand;
                            process.StartInfo = startInfo;
                            process.Start();

                            Progress.Value = i + 1;
                        }

                        Label.Text = "Done converting files";
                    } else
                    {
                        Console.WriteLine("Invalid Citicon file");
                    }
                } else
                {
                    Console.WriteLine("No .ydr files found");
                }
            } else
            {
                Console.WriteLine("Bad parameters");
            }
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            ConversionButton.Width = this.Width - 48;
            ConversionButton.Top = this.Height - 100;
            ConversionButton.Left = 16;

            Progress.Width = this.Width - 48;
            Progress.Top = this.Height - 175;
            Progress.Left = 16;

            Label.Left = this.Width / 2 - (Label.Width / 2);

            SelectYDRFolder.Left = this.Width - SelectYDRFolder.Width - 32;
            SelectCiticon.Left = this.Width - SelectYDRFolder.Width - 32;
        }

        private void SelectYDRFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                YDRFolderLabel.Text = FolderBrowser.SelectedPath;
            }
        }

        private void SelectCiticon_Click(object sender, EventArgs e)
        {
            DialogResult result = FileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                CiticonLabel.Text = FileDialog.FileName;
            }
        }
    }
}
