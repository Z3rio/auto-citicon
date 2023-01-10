using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void SelectYDRFolder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
