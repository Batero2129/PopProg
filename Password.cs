using System;
using System.Windows.Forms;

namespace PopProg
{
    public partial class Password : Form
    {
        private string _pass = "2129";
        private string _enterPass;
        private bool _isAllDone;

        public bool PassDone { get => _isAllDone; }

        public Password()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            label1.Text = "";
            _isAllDone = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button10.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            _enterPass += button9.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_pass == _enterPass)
            {
                _isAllDone = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный пароль!!!");
                _enterPass = "";
                label1.Text = "";
            }
        }
    }
}
