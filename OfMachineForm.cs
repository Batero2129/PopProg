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
    public partial class OfMachineForm : Form
    {
        private string _machineType1 = "АВР";
        private string _machineType2 = "АВРМ";
        private string _machineType3 = "ВРП";
        private string _machineType4 = "ТДВ";
        private string _machineType5 = "ТДВУ";
        private string _machineType6 = "КДВ";
        private string _machineType7 = "КДВУ";
        private string _machineType8 = "ВМЭ";
        private string _machineType9 = "Ремонт";
        private string _machineType10 = "50х100";
        private string _machineType11 = "80х100";
        private string _machineType12 = "";
        private string _machineType13 = "";
        private string _machineType14 = "";
        private string _machineType15 = "";
        private string _machineType16 = "ПУСТАЯ";

        public string MachineTypeChoice { get; set; }


        public OfMachineForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            if (_machineType1 != "") button1.Text = _machineType1;
            else button1.Visible = false;
            if (_machineType2 != "") button2.Text = _machineType2;
            else button2.Visible = false;
            if (_machineType3 != "") button3.Text = _machineType3;
            else button3.Visible = false;
            if (_machineType4 != "") button4.Text = _machineType4;
            else button4.Visible = false;
            if (_machineType5 != "") button5.Text = _machineType5;
            else button5.Visible = false;
            if (_machineType6 != "") button6.Text = _machineType6;
            else button6.Visible = false;
            if (_machineType7 != "") button7.Text = _machineType7;
            else button7.Visible = false;
            if (_machineType8 != "") button8.Text = _machineType8;
            else button8.Visible = false;
            if (_machineType9 != "") button9.Text = _machineType9;
            else button9.Visible = false;
            if (_machineType10 != "") button10.Text = _machineType10;
            else button10.Visible = false;
            if (_machineType11 != "") button11.Text = _machineType11;
            else button11.Visible = false;
            if (_machineType12 != "") button12.Text = _machineType12;
            else button12.Visible = false;
            if (_machineType13 != "") button13.Text = _machineType13;
            else button13.Visible = false;
            if (_machineType14 != "") button14.Text = _machineType14;
            else button14.Visible = false;
            if (_machineType15 != "") button15.Text = _machineType15;
            else button15.Visible = false;
            if (_machineType16 != "") button16.Text = _machineType16;
            else button16.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType1;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType2;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType3;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType4;
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType5;
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType6;
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType7;
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType8;
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType9;
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType10;
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType11;
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType12;
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType13;
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType14;
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = _machineType15;
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MachineTypeChoice = "";
            this.Hide();

        }
    }
}
