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
    public partial class AmountUnitForm : Form
    {
        public int Amount { get; private set; }
        public string Units { get; private set; }

        public AmountUnitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            Amount = Convert.ToInt32(label1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amount += 1;
            GetAmount();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amount += 10;
            GetAmount();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Amount += 100;
            GetAmount();
        }

        private void GetAmount()
        {
            label1.Text = Convert.ToString(Amount);
            label1.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Amount<= 0)
            {
                MessageBox.Show("Ошибка!!! Неверное количество! Исправьте количество!");
            }
            else
            {
            Units = "шт.";
            this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Amount <= 0)
            {
                MessageBox.Show("Ошибка!!! Неверное количество! Исправьте количество!");
            }
            else
            {
                Units = "час.";
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Amount -= 1;
            GetAmount();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Amount -= 10;
            GetAmount();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Amount -= 100;
            GetAmount();

        }
    }
}
