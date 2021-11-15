using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Data.Common;

namespace PopProg
{
    public partial class MainForm : Form
    {
        private string _date;
        private string _fio;
        private string _stanok;
        private string _workType;
        private string _partType;
        private string _ofMachine;
        private string _sizer;
        private string _execution;
        private string _amount;
        private string _units;

        private string _strokaObsh;
        Timer timer = new Timer();


        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            //LoadDB();
            timer = new Timer(); // создаем новый таймер
            timer.Interval = 2000; // ставим интервал выполнения единственного события, через 5 секунд
            timer.Tick += SaverToTime; // создаем событие
            timer.Enabled = true;// включаем таймер
            timer.Start();

        }

        private void SaverToTime(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FIO fio = new FIO();
            StanokForm stanokForm = new StanokForm();
            WorkTypeForm workType = new WorkTypeForm();
            OfMachineForm ofMachine = new OfMachineForm();
            PartTypeEssembly typeEssembly = new PartTypeEssembly();
            PartTypePlasmaForm partTypePlasma = new PartTypePlasmaForm();
            OfMachineForm machineForm = new OfMachineForm();
            SizerForm1 sizerForm = new SizerForm1();
            ExecutionForm executionForm = new ExecutionForm();
            ConfirmForm confirmForm = new ConfirmForm();
            AmountUnitForm amountUnitForm = new AmountUnitForm();

            fio.ShowDialog();
            _fio = fio.FIOchoice;

            stanokForm.ShowDialog();
            _stanok = stanokForm.StanokChoice;

            workType.ShowDialog();
            _workType = workType.WorkTypeChoise;

            if (_stanok != "Плазма")
            {
                typeEssembly.ShowDialog();
                _partType = typeEssembly.PartTypeChoice;
            }
            else
            {
                partTypePlasma.ShowDialog();
                _partType = partTypePlasma.partTypeChoice;
            }

            machineForm.ShowDialog();
            _ofMachine = machineForm.MachineTypeChoice;

            sizerForm.ShowDialog();
            _sizer = sizerForm.SizerFormChoise;

            executionForm.ShowDialog();
            _execution = executionForm.ExeForm;

            amountUnitForm.ShowDialog();
            _amount = Convert.ToString(amountUnitForm.Amount);
            _units = amountUnitForm.Units;

            GetData();
            confirmForm.GetData(_strokaObsh);
            confirmForm.ShowDialog();
            if (confirmForm.IsALLDone == "NO")
            {
                _date = "";
                _fio = "";
                _stanok = "";
                _workType = "";
                _partType = "";
                _ofMachine = "";
                _sizer = "";
                _execution = "";
                _amount = "";
                _units = "";


                stanokForm.Close();
                workType.Close();
                ofMachine.Close();
                typeEssembly.Close();
                partTypePlasma.Close();
                machineForm.Close();
                sizerForm.Close();
                executionForm.Close();
                amountUnitForm.Close();
                confirmForm.Close();

            }
            else if (confirmForm.IsALLDone == "YES")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = _date;
                dataGridView1.Rows[n].Cells[1].Value = _fio;
                dataGridView1.Rows[n].Cells[2].Value = _stanok;
                dataGridView1.Rows[n].Cells[3].Value = _workType;
                dataGridView1.Rows[n].Cells[4].Value = _partType;
                dataGridView1.Rows[n].Cells[5].Value = _ofMachine + _sizer + _execution;
                dataGridView1.Rows[n].Cells[6].Value = _amount;
                dataGridView1.Rows[n].Cells[7].Value = _units;

            }

            GetData();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
        }


        private void GetData()
        {
            DateTime now = DateTime.Now;
            _date = now.ToString(("d"));
            _strokaObsh = _date + " " + _fio + " " + _stanok + " " + _workType + " " + _partType + " " + _ofMachine + _sizer + _execution + " " + _amount + _units;
            label1.Text = _strokaObsh;



        }

        private void button5_Click(object sender, EventArgs e) //Мастер
        {
            if (_fio != "" && _fio != null)
            {
                Password password = new Password();
                password.ShowDialog();

                if (password.PassDone)
                {
                    MasterForm masterForm = new MasterForm();
                    masterForm.InputData(dataGridView1);
                    masterForm.ShowDialog();
                    dataGridView1.Rows.Clear();
                    _fio = null;
                }

            }
            else MessageBox.Show("Ошибка!!! Еще никто не сдал работу");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TabelForm tabelForm = new TabelForm();

            tabelForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewWork newWorkForm = new NewWork();
            newWorkForm.ShowDialog();
        }
    }
}
