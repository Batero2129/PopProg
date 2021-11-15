using System;
using System.Windows.Forms;

namespace PopProg
{
    public partial class ConfirmForm : Form
    {
        public string LabelTEST { get; set; }
        public string IsALLDone { get; set; }

        public ConfirmForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsALLDone = "YES";
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsALLDone = "NO";
            this.Hide();
        }

        public void GetData(string text)
        {
            label1.Text = text;
        }

    }
}
