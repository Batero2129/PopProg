using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopProg
{
    public partial class AddNewDvigForm : Form
    {
        public AddNewDvigForm()
        {
            InitializeComponent();

            LoadData_Parts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text + comboBox2.Text + comboBox3.Text + comboBox4.Text + " " + comboBox5.Text + " " + textBox1.Text;
            string nameDvig = label7.Text;

            //ЗАГРУЗКА ФАЙЛА
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"C:\KEMZData\BD\DataTable\FilesOfDvig\"+ nameDvig + ".xml");
                foreach (DataRow item in dataSet.Tables["Table"].Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = item["FileNameOfDvig"];
                    dataGridView3.Rows[n].Cells[1].Value = item["FilePathOfDvig"];

                }

        }

        private void LoadData_Parts()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\KEMZData\BD\DataTable\ListOfParts.xml");
            foreach (DataRow item in dataSet.Tables["PartSheet"].Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["Part_WorkBench"];
                dataGridView2.Rows[n].Cells[1].Value = item["Part_Metall"];
                dataGridView2.Rows[n].Cells[1].Value = item["Part_Name"];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null & textBox3.Text !=null & textBox4.Text != null)
            {

            }
            else
            {
                MessageBox.Show("Введите зачения!");
            }
        }
    }
}
