using System;
using System.Windows.Forms;

namespace PopProg
{
    public partial class PartTypeEssembly : Form
    {
        private string _partType1 = "Статор";
        private string _partType2 = "Ротор";
        private string _partType3 = "Статор+ Ротор";
        private string _partType4 = "Статор- Ротор";
        private string _partType5 = "Концевая";
        private string _partType6 = "Табличка";
        private string _partType7 = "Балансир. грузик";
        private string _partType8 = "Заглушка";
        private string _partType9 = "Заготовка ротор";
        private string _partType10 = "Заготовка статор";
        private string _partType11 = "Сердечник статорный";
        private string _partType12 = "Детали";
        private string _partType13 = "";
        private string _partType14 = "";
        private string _partType15 = "";
        private string _partType16 = "";
        private string _partType17 = "";
        private string _partType18 = "Пустая";

        public string PartTypeChoice { get; set; }


        public PartTypeEssembly()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            if (_partType1 != "") button1.Text = _partType1;
            else button1.Visible = false;

            if (_partType2 != "") button2.Text = _partType2;
            else button2.Visible = false;

            if (_partType3 != "") button3.Text = _partType3;
            else button3.Visible = false;

            if (_partType4 != "") button4.Text = _partType4;
            else button4.Visible = false;

            if (_partType5 != "") button5.Text = _partType5;
            else button5.Visible = false;

            if (_partType6 != "") button6.Text = _partType6;
            else button6.Visible = false;

            if (_partType7 != "") button7.Text = _partType7;
            else button7.Visible = false;

            if (_partType8 != "") button8.Text = _partType8;
            else button8.Visible = false;

            if (_partType9 != "") button9.Text = _partType9;
            else button9.Visible = false;

            if (_partType10 != "") button10.Text = _partType10;
            else button10.Visible = false;

            if (_partType11 != "") button11.Text = _partType11;
            else button11.Visible = false;

            if (_partType12 != "") button12.Text = _partType12;
            else button12.Visible = false;

            if (_partType13 != "") button13.Text = _partType13;
            else button13.Visible = false;

            if (_partType14 != "") button14.Text = _partType14;
            else button14.Visible = false;

            if (_partType15 != "") button15.Text = _partType15;
            else button15.Visible = false;

            if (_partType16 != "") button16.Text = _partType16;
            else button16.Visible = false;

            if (_partType17 != "") button17.Text = _partType17;
            else button17.Visible = false;

            if (_partType18 != "") button18.Text = _partType18;
            else button18.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button1.Text;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button2.Text;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button3.Text;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button4.Text;
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button5.Text;
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button6.Text;
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button7.Text;
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button8.Text;
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button9.Text;
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button10.Text;
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button11.Text;
            this.Hide();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button12.Text;
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button13.Text;
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button14.Text;
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button15.Text;
            this.Hide();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button16.Text;
            this.Hide();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            PartTypeChoice = button17.Text;
            this.Hide();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            PartTypeChoice = "";
            this.Hide();

        }
    }
}
