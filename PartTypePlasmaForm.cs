using System;
using System.Windows.Forms;

namespace PopProg
{
    public partial class PartTypePlasmaForm : Form
    {
        private string _patrTypePlasma1 = "Балансир. диск";
        private string _patrTypePlasma2 = "Большая боковина";
        private string _patrTypePlasma3 = "Детали";
        private string _patrTypePlasma4 = "Диск вентилятора";
        private string _patrTypePlasma5 = "Диск заднего щита";
        private string _patrTypePlasma6 = "Диск переднего щита";
        private string _patrTypePlasma7 = "Дно КВ";
        private string _patrTypePlasma8 = "Дно кожуха (Лап)";
        private string _patrTypePlasma9 = "Дно кожуха (Фл)";
        private string _patrTypePlasma10 = "Дно ПП";

        private string _patrTypePlasma11 = "Дно ПП";
        private string _patrTypePlasma12 = "Запорная шайба";
        private string _patrTypePlasma13 = "Кольцо щита";
        private string _patrTypePlasma14 = "Крышка";
        private string _patrTypePlasma15 = "Крышка ВП";
        private string _patrTypePlasma16 = "Лопасть вентилятора";
        private string _patrTypePlasma17 = "Малая боковина";
        private string _patrTypePlasma18 = "Нажимное кольцо";
        private string _patrTypePlasma19 = "Панель";
        private string _patrTypePlasma20 = "Планка кожуха";
                                          
        private string _patrTypePlasma21 = "Планка лапы";
        private string _patrTypePlasma22 = "Пластина лапы";
        private string _patrTypePlasma23 = "Пластина для КВ";
        private string _patrTypePlasma24 = "Подкладка лапы";
        private string _patrTypePlasma25 = "Полоса на кольцо баланс. диска";
        private string _patrTypePlasma26 = "Полоса на кольцо щита";
        private string _patrTypePlasma27 = "Пружинное кольцо";
        private string _patrTypePlasma28 = "Развертка на трубу";
        private string _patrTypePlasma29 = "Ребро";
        private string _patrTypePlasma30 = "Скоба под масленку";
                                          
        private string _patrTypePlasma31 = "Трансп. Ухо"; 
        private string _patrTypePlasma32 = "Укосина лапы";
        private string _patrTypePlasma33 = "Флянец ВП";
        private string _patrTypePlasma34 = "Флянец КВ";
        private string _patrTypePlasma35 = "Флянец станины";
        private string _patrTypePlasma36 = "Флянец щита";
        private string _patrTypePlasma37 = "Цилиндр ВП";
        private string _patrTypePlasma38 = "Цилиндр КВ";
        private string _patrTypePlasma39 = "Цилиндр кожуха (Лап)";
        private string _patrTypePlasma40 = "Цилиндр кожуха (Фл)"; 

        public string partTypeChoice { get; set; }

        public PartTypePlasmaForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            if (_patrTypePlasma1 != "") button1.Text = _patrTypePlasma1;
            else button1.Visible = false;
            if (_patrTypePlasma2 != "") button2.Text = _patrTypePlasma2;
            else button2.Visible = false;
            if (_patrTypePlasma3 != "") button3.Text = _patrTypePlasma3;
            else button3.Visible = false;
            if (_patrTypePlasma4 != "") button4.Text = _patrTypePlasma4;
            else button4.Visible = false;
            if (_patrTypePlasma5 != "") button5.Text = _patrTypePlasma5;
            else button5.Visible = false;
            if (_patrTypePlasma6 != "") button6.Text = _patrTypePlasma6;
            else button6.Visible = false;
            if (_patrTypePlasma7 != "") button7.Text = _patrTypePlasma7;
            else button7.Visible = false;
            if (_patrTypePlasma8 != "") button8.Text = _patrTypePlasma8;
            else button8.Visible = false;
            if (_patrTypePlasma9 != "") button9.Text = _patrTypePlasma9;
            else button9.Visible = false;
            if (_patrTypePlasma10 != "") button10.Text = _patrTypePlasma10;
            else button10.Visible = false;

            if (_patrTypePlasma11 != "") button11.Text = _patrTypePlasma11;
            else button11.Visible = false;
            if (_patrTypePlasma12 != "") button12.Text = _patrTypePlasma12;
            else button12.Visible = false;
            if (_patrTypePlasma13 != "") button13.Text = _patrTypePlasma13;
            else button13.Visible = false;
            if (_patrTypePlasma14 != "") button14.Text = _patrTypePlasma14;
            else button14.Visible = false;
            if (_patrTypePlasma15 != "") button15.Text = _patrTypePlasma15;
            else button15.Visible = false;
            if (_patrTypePlasma16 != "") button16.Text = _patrTypePlasma16;
            else button16.Visible = false;
            if (_patrTypePlasma17 != "") button17.Text = _patrTypePlasma17;
            else button17.Visible = false;
            if (_patrTypePlasma18 != "") button18.Text = _patrTypePlasma18;
            else button18.Visible = false;
            if (_patrTypePlasma19 != "") button19.Text = _patrTypePlasma19;
            else button19.Visible = false;
            if (_patrTypePlasma20 != "") button20.Text = _patrTypePlasma20;
            else button20.Visible = false;

            if (_patrTypePlasma21 != "") button21.Text = _patrTypePlasma21;
            else button21.Visible = false;
            if (_patrTypePlasma22 != "") button22.Text = _patrTypePlasma22;
            else button22.Visible = false;
            if (_patrTypePlasma23 != "") button23.Text = _patrTypePlasma23;
            else button23.Visible = false;
            if (_patrTypePlasma24 != "") button24.Text = _patrTypePlasma24;
            else button24.Visible = false;
            if (_patrTypePlasma25 != "") button25.Text = _patrTypePlasma25;
            else button25.Visible = false;
            if (_patrTypePlasma26 != "") button26.Text = _patrTypePlasma26;
            else button26.Visible = false;
            if (_patrTypePlasma27 != "") button27.Text = _patrTypePlasma27;
            else button27.Visible = false;
            if (_patrTypePlasma28 != "") button28.Text = _patrTypePlasma28;
            else button28.Visible = false;
            if (_patrTypePlasma29 != "") button29.Text = _patrTypePlasma29;
            else button29.Visible = false;
            if (_patrTypePlasma30 != "") button30.Text = _patrTypePlasma30;
            else button30.Visible = false;

            if (_patrTypePlasma31 != "") button31.Text = _patrTypePlasma31;
            else button31.Visible = false;
            if (_patrTypePlasma32 != "") button32.Text = _patrTypePlasma32;
            else button32.Visible = false;
            if (_patrTypePlasma33 != "") button33.Text = _patrTypePlasma33;
            else button33.Visible = false;
            if (_patrTypePlasma34 != "") button34.Text = _patrTypePlasma34;
            else button34.Visible = false;
            if (_patrTypePlasma35 != "") button35.Text = _patrTypePlasma35;
            else button35.Visible = false;
            if (_patrTypePlasma36 != "") button36.Text = _patrTypePlasma36;
            else button36.Visible = false;
            if (_patrTypePlasma37 != "") button37.Text = _patrTypePlasma37;
            else button37.Visible = false;
            if (_patrTypePlasma38 != "") button38.Text = _patrTypePlasma38;
            else button38.Visible = false;
            if (_patrTypePlasma39 != "") button39.Text = _patrTypePlasma39;
            else button39.Visible = false;
            if (_patrTypePlasma40 != "") button40.Text = _patrTypePlasma40;
            else button40.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            partTypeChoice = button1.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            partTypeChoice = button2.Text;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            partTypeChoice = button3.Text;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            partTypeChoice = button4.Text;
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            partTypeChoice = button5.Text;
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            partTypeChoice = button6.Text;
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            partTypeChoice = button7.Text;
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            partTypeChoice = button8.Text;
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            partTypeChoice = button9.Text;
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            partTypeChoice = button10.Text;
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            partTypeChoice = button11.Text;
            this.Hide();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            partTypeChoice = button12.Text;
            this.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            partTypeChoice = button13.Text;
            this.Hide();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            partTypeChoice = button14.Text;
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            partTypeChoice = button15.Text;
            this.Hide();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            partTypeChoice = button16.Text;
            this.Hide();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            partTypeChoice = button17.Text;
            this.Hide();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            partTypeChoice = button18.Text;
            this.Hide();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            partTypeChoice = button19.Text;
            this.Hide();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            partTypeChoice = button20.Text;
            this.Hide();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            partTypeChoice = button21.Text;
            this.Hide();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            partTypeChoice = button22.Text;
            this.Hide();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            partTypeChoice = button23.Text;
            this.Hide();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            partTypeChoice = button24.Text;
            this.Hide();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            partTypeChoice = button25.Text;
            this.Hide();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            partTypeChoice = button26.Text;
            this.Hide();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            partTypeChoice = button27.Text;
            this.Hide();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            partTypeChoice = button28.Text;
            this.Hide();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            partTypeChoice = button29.Text;
            this.Hide();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            partTypeChoice = button30.Text;
            this.Hide();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            partTypeChoice = button31.Text;
            this.Hide();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            partTypeChoice = button32.Text;
            this.Hide();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            partTypeChoice = button33.Text;
            this.Hide();

        }

        private void button34_Click(object sender, EventArgs e)
        {
            partTypeChoice = button34.Text;
            this.Hide();

        }

        private void button35_Click(object sender, EventArgs e)
        {
            partTypeChoice = button35.Text;
            this.Hide();

        }

        private void button36_Click(object sender, EventArgs e)
        {
            partTypeChoice = button36.Text;
            this.Hide();

        }

        private void button37_Click(object sender, EventArgs e)
        {
            partTypeChoice = button37.Text;
            this.Hide();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            partTypeChoice = button38.Text;
            this.Hide();

        }

        private void button39_Click(object sender, EventArgs e)
        {
            partTypeChoice = button39.Text;
            this.Hide();

        }

        private void button40_Click(object sender, EventArgs e)
        {
            partTypeChoice = button40.Text;
            this.Hide();

        }
    }
}
