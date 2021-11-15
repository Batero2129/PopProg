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
    public partial class StanokForm : Form
    {
        private string _stanok1 = "Пазник Ст.";
        private string _stanok2 = "Пазник Нов.";
        private string _stanok3 = "Плазма";
        private string _stanok4 = "Лазер 1кВт";
        private string _stanok5 = "Бакинец";
        private string _stanok6 = "Шихтовка";
        private string _stanok7 = "";
        private string _stanok8 = "";
        private string _stanok9 = "";
        private string _stanok10 = "";
        private string _stanok11 = "";
        private string _stanok12 = "";
        private string _stanok13 = "";
        private string _stanok14 = "";
        private string _stanok15 = "";

        private string _stanokChoice;

        ClassBase classBase = new ClassBase();

        public StanokForm()
        {
            InitializeComponent();

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
            _stanokChoice = button1.Text;
            classBase.LoadSTR(_stanokChoice);
            //StanokForm stanokForm = new StanokForm();
            //stanokForm.Show();

            MessageBox.Show(classBase.OutMess());
        }
    }
}
