namespace Auto_Citicon
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.ConversionButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Label = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.YDRFolderLabel = new System.Windows.Forms.Label();
            this.YDRFolderPath = new System.Windows.Forms.Label();
            this.SelectYDRFolder = new System.Windows.Forms.Button();
            this.SelectCiticon = new System.Windows.Forms.Button();
            this.CiticonPath = new System.Windows.Forms.Label();
            this.CiticonLabel = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ConversionButton
            // 
            this.ConversionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConversionButton.AutoSize = true;
            this.ConversionButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversionButton.Location = new System.Drawing.Point(16, 300);
            this.ConversionButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConversionButton.Name = "ConversionButton";
            this.ConversionButton.Size = new System.Drawing.Size(552, 50);
            this.ConversionButton.TabIndex = 0;
            this.ConversionButton.Text = "Start Converting";
            this.ConversionButton.UseVisualStyleBackColor = true;
            this.ConversionButton.Click += new System.EventHandler(this.ConversionButton_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(16, 225);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(552, 50);
            this.Progress.Step = 1;
            this.Progress.TabIndex = 1;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(165, 16);
            this.Label.Margin = new System.Windows.Forms.Padding(0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(270, 32);
            this.Label.TabIndex = 2;
            this.Label.Text = "Tool not started yet";
            // 
            // YDRFolderLabel
            // 
            this.YDRFolderLabel.AutoSize = true;
            this.YDRFolderLabel.Location = new System.Drawing.Point(16, 70);
            this.YDRFolderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.YDRFolderLabel.Name = "YDRFolderLabel";
            this.YDRFolderLabel.Size = new System.Drawing.Size(123, 13);
            this.YDRFolderLabel.TabIndex = 3;
            this.YDRFolderLabel.Text = "YDR Folder not selected";
            // 
            // YDRFolderPath
            // 
            this.YDRFolderPath.AutoSize = true;
            this.YDRFolderPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YDRFolderPath.Location = new System.Drawing.Point(16, 90);
            this.YDRFolderPath.Margin = new System.Windows.Forms.Padding(0);
            this.YDRFolderPath.Name = "YDRFolderPath";
            this.YDRFolderPath.Size = new System.Drawing.Size(0, 13);
            this.YDRFolderPath.TabIndex = 4;
            // 
            // SelectYDRFolder
            // 
            this.SelectYDRFolder.Location = new System.Drawing.Point(441, 70);
            this.SelectYDRFolder.Name = "SelectYDRFolder";
            this.SelectYDRFolder.Size = new System.Drawing.Size(121, 23);
            this.SelectYDRFolder.TabIndex = 5;
            this.SelectYDRFolder.Text = "Select YDR Folder";
            this.SelectYDRFolder.UseVisualStyleBackColor = true;
            this.SelectYDRFolder.Click += new System.EventHandler(this.SelectYDRFolder_Click);
            // 
            // SelectCiticon
            // 
            this.SelectCiticon.Location = new System.Drawing.Point(441, 125);
            this.SelectCiticon.Name = "SelectCiticon";
            this.SelectCiticon.Size = new System.Drawing.Size(121, 23);
            this.SelectCiticon.TabIndex = 8;
            this.SelectCiticon.Text = "Select Citicon";
            this.SelectCiticon.UseVisualStyleBackColor = true;
            this.SelectCiticon.Click += new System.EventHandler(this.SelectCiticon_Click);
            // 
            // CiticonPath
            // 
            this.CiticonPath.AutoSize = true;
            this.CiticonPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CiticonPath.Location = new System.Drawing.Point(16, 145);
            this.CiticonPath.Margin = new System.Windows.Forms.Padding(0);
            this.CiticonPath.Name = "CiticonPath";
            this.CiticonPath.Size = new System.Drawing.Size(0, 13);
            this.CiticonPath.TabIndex = 7;
            // 
            // CiticonLabel
            // 
            this.CiticonLabel.AutoSize = true;
            this.CiticonLabel.Location = new System.Drawing.Point(16, 125);
            this.CiticonLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CiticonLabel.Name = "CiticonLabel";
            this.CiticonLabel.Size = new System.Drawing.Size(100, 13);
            this.CiticonLabel.TabIndex = 6;
            this.CiticonLabel.Text = "Citicon not selected";
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "com files (*.com)|*.com|All files (*.*)|*.*";
            this.FileDialog.InitialDirectory = "%localappdata%\\RedM\\RedM.app";
            // 
            // Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.SelectCiticon);
            this.Controls.Add(this.CiticonPath);
            this.Controls.Add(this.CiticonLabel);
            this.Controls.Add(this.SelectYDRFolder);
            this.Controls.Add(this.YDRFolderPath);
            this.Controls.Add(this.YDRFolderLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.ConversionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Handler";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConversionButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label YDRFolderLabel;
        private System.Windows.Forms.Label YDRFolderPath;
        private System.Windows.Forms.Button SelectYDRFolder;
        private System.Windows.Forms.Button SelectCiticon;
        private System.Windows.Forms.Label CiticonPath;
        private System.Windows.Forms.Label CiticonLabel;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

