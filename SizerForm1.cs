using System;
using System.Windows.Forms;

namespace PopProg
{
    public partial class SizerForm1 : Form
    {

        public string SizerFormChoise { get; set; }

        public SizerForm1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button1.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button2.Text;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button3.Text;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button4.Text;
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button5.Text;
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button6.Text;
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button7.Text;
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button8.Text;
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SizerFormChoise = button9.Text;
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SizerFormChoise = ""; //Пустая кнопка
            this.Hide();
        }
    }
}
