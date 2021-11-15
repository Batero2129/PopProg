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
        public string FIOchoice { get; set; }


        public FIO()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            MasterForm masterForm = new MasterForm();
            string[] lW = masterForm.TakeData();
            Button[] btn = new Button[]
            {button1,button2,button3,button4,button5,
                button6,button7,button8,button9,button10,
                button11,button12,button13,button14,button15,
                button16,button17,button18,button19,button20 };

            if (lW.Length < 20)
            {
                for (int i = 0; i < lW.Length; i++)
                {
                    btn[i].Text = lW[i];
                    btn[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    btn[i].Text = lW[i];
                    btn[i].Visible = true;
                }

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //здесь sender - ссылка на кнопку, запустившую обработчик
            //например:
            FIOchoice = (sender as Button).Text; // выводим текст кнопки 
            this.Hide();
        }
    }
}
