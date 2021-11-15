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
    public partial class FIO : Form
    {
        private string _operator1 = "Карелин Д.С.";
        private string _operator2 = "Кулык Д.В.";
        private string _operator3 = "Мальков В.В.";
        private string _operator4 = "Матюшенок Т.";
        private string _operator5 = "Павлов Е.Ю.";
        private string _operator6 = "Сотсков А.В.";
        private string _operator7 = "Суворов О.А.";
        private string _operator8 = "Шарыпин Д.А";
        private string _operator9 = "Щеглов С.А.";
        private string _operator10 = "Щукин С.И.";
        private string _operator11 = "";
        private string _operator12 = "";
        private string _operator13 = "";
        private string _operator14 = "";
        private string _operator15 = "";
        private string _operator16 = "";
        private string _operator17 = "";
        private string _operator18 = "";
        private string _operator19 = "";
        private string _operator20 = "";

        private string _FIOchoice;

        ClassBase classBase = new ClassBase();

        public FIO()
        {
            InitializeComponent();

            if (_operator1 != "") button1.Text = _operator1;
            else button1.Visible = false;

            if (_operator2 != "") button2.Text = _operator2;
            else button2.Visible = false;

            if (_operator3 != "") button3.Text = _operator3;
            else button3.Visible = false;

            if (_operator4 != "") button4.Text = _operator4;
            else button4.Visible = false;

            if (_operator5 != "") button5.Text = _operator5;
            else button5.Visible = false;

            if (_operator6 != "") button6.Text = _operator6;
            else button6.Visible = false;

            if (_operator7 != "") button7.Text = _operator7;
            else button7.Visible = false;

            if (_operator8 != "") button8.Text = _operator8;
            else button8.Visible = false;

            if (_operator9 != "") button9.Text = _operator9;
            else button9.Visible = false;

            if (_operator10 != "") button10.Text = _operator10;
            else button10.Visible = false;

            if (_operator11 != "") button11.Text = _operator11;
            else button11.Visible = false;

            if (_operator12 != "") button12.Text = _operator12;
            else button12.Visible = false;

            if (_operator13 != "") button13.Text = _operator13;
            else button13.Visible = false;

            if (_operator14 != "") button14.Text = _operator14;
            else button14.Visible = false;

            if (_operator15 != "") button15.Text = _operator15;
            else button15.Visible = false;

            if (_operator16 != "") button16.Text = _operator16;
            else button16.Visible = false;

            if (_operator17 != "") button17.Text = _operator17;
            else button17.Visible = false;

            if (_operator18 != "") button18.Text = _operator18;
            else button18.Visible = false;

            if (_operator19 != "") button19.Text = _operator19;
            else button19.Visible = false;

            if (_operator20 != "") button20.Text = _operator20;
            else button20.Visible = false;



        }


        private void button1_Click(object sender, EventArgs e)
        {
            _FIOchoice = button1.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            //stanokForm.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _FIOchoice = button2.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            //stanokForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _FIOchoice = button3.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            _FIOchoice = button4.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            _FIOchoice = button5.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            _FIOchoice = button6.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            _FIOchoice = button7.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            _FIOchoice = button8.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            _FIOchoice = button9.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            _FIOchoice = button10.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            _FIOchoice = button11.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            _FIOchoice = button12.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            _FIOchoice = button13.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button14_Click(object sender, EventArgs e)
        {
            _FIOchoice = button14.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button15_Click(object sender, EventArgs e)
        {
            _FIOchoice = button16.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button16_Click(object sender, EventArgs e)
        {
            _FIOchoice = button16.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button17_Click(object sender, EventArgs e)
        {
            _FIOchoice = button17.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button18_Click(object sender, EventArgs e)
        {
            _FIOchoice = button18.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button19_Click(object sender, EventArgs e)
        {
            _FIOchoice = button19.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        private void button20_Click(object sender, EventArgs e)
        {
            _FIOchoice = button20.Text;
            classBase.LoadSTR(_FIOchoice);
            StanokForm stanokForm = new StanokForm();
            stanokForm.Show();


        }

        public string OutDataFIO()
        {

        }
    }
}
