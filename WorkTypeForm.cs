using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopProg
{
    public partial class WorkTypeForm : Form
    {
        private string _workType1 = "Делить";
        private string _workType2 = "Рубить";
        private string _workType3 = "Резать";
        private string _workType4 = "Слесарная обработка";
        private string _workType5 = "Собирать";
        private string _workType6 = "Транспортировка";
        private string _workType7 = "Заливка";
        private string _workType8 = "Ремонт";
        private string _workType9 = "Установка штампа";
        private string _workType10 = "Снятие штампа";
        private string _workType11 = "Запрессовка";
        private string _workType12 = "Шлифовка";
        private string _workType13 = "Распил";
        private string _workType14 = "";
        private string _workType15 = "";


        public string WorkTypeChoise { get; set; }


        public WorkTypeForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;


            if (_workType1 != "") button1.Text = _workType1;
            else button1.Visible = false;

            if (_workType2 != "") button2.Text = _workType2;
            else button2.Visible = false;

            if (_workType3 != "") button3.Text = _workType3;
            else button3.Visible = false;

            if (_workType4 != "") button4.Text = _workType4;
            else button4.Visible = false;

            if (_workType5 != "") button5.Text = _workType5;
            else button5.Visible = false;

            if (_workType6 != "") button6.Text = _workType6;
            else button6.Visible = false;

            if (_workType7 != "") button7.Text = _workType7;
            else button7.Visible = false;

            if (_workType8 != "") button8.Text = _workType8;
            else button8.Visible = false;

            if (_workType9 != "") button9.Text = _workType9;
            else button9.Visible = false;

            if (_workType10 != "") button10.Text = _workType10;
            else button10.Visible = false;

            if (_workType11 != "") button11.Text = _workType11;
            else button11.Visible = false;

            if (_workType12 != "") button12.Text = _workType12;
            else button12.Visible = false;

            if (_workType13 != "") button13.Text = _workType13;
            else button13.Visible = false;

            if (_workType14 != "") button14.Text = _workType14;
            else button14.Visible = false;

            if (_workType15 != "") button15.Text = _workType15;
            else button15.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button10.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button11.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button12.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button13.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button14.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTypeChoise = button15.Text;

        }
    }
}
