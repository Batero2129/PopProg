using System;
using System.Windows.Forms;

namespace PopProg
{
    public partial class StanokForm : Form
    {
        private string _stanok1 = "Пазник";
        private string _stanok2 = "Пазник Нов.";
        private string _stanok3 = "Плазма";
        private string _stanok4 = "Лазер 1кВт";
        private string _stanok5 = "Бакинец";
        private string _stanok6 = "Шихтовка";
        private string _stanok7 = "Пресс 400т";
        private string _stanok8 = "Пресс 630т";
        private string _stanok9 = "13-й ЦЕХ";
        private string _stanok10 = "5-й ЦЕХ";
        private string _stanok11 = "";
        private string _stanok12 = "";
        private string _stanok13 = "";
        private string _stanok14 = "";
        private string _stanok15 = "";

        public string StanokChoice { get; set; }

        public StanokForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;



            if (_stanok1 != "") button1.Text = _stanok1;
            else button1.Visible = false;

            if (_stanok2 != "") button2.Text = _stanok2;
            else button2.Visible = false;

            if (_stanok3 != "") button3.Text = _stanok3;
            else button3.Visible = false;

            if (_stanok4 != "") button4.Text = _stanok4;
            else button4.Visible = false;

            if (_stanok5 != "") button5.Text = _stanok5;
            else button5.Visible = false;

            if (_stanok6 != "") button6.Text = _stanok6;
            else button6.Visible = false;

            if (_stanok7 != "") button7.Text = _stanok7;
            else button7.Visible = false;

            if (_stanok8 != "") button8.Text = _stanok8;
            else button8.Visible = false;

            if (_stanok9 != "") button9.Text = _stanok9;
            else button9.Visible = false;

            if (_stanok10 != "") button10.Text = _stanok10;
            else button10.Visible = false;

            if (_stanok11 != "") button11.Text = _stanok11;
            else button11.Visible = false;

            if (_stanok12 != "") button12.Text = _stanok12;
            else button12.Visible = false;

            if (_stanok13 != "") button13.Text = _stanok13;
            else button13.Visible = false;

            if (_stanok14 != "") button14.Text = _stanok14;
            else button14.Visible = false;

            if (_stanok15 != "") button15.Text = _stanok15;
            else button15.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StanokChoice = button1.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StanokChoice = button2.Text;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StanokChoice = button3.Text;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StanokChoice = button4.Text;
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StanokChoice = button5.Text;
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StanokChoice = button6.Text;
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StanokChoice = button7.Text;
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            StanokChoice = button8.Text;
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            StanokChoice = button9.Text;
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            StanokChoice = button10.Text;
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            StanokChoice = button11.Text;
            this.Hide();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            StanokChoice = button12.Text;
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            StanokChoice = button13.Text;
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            StanokChoice = button14.Text;
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            StanokChoice = button15.Text;
            this.Hide();

        }
    }
}
