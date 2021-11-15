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

        public MainForm()
        {
            InitializeComponent();

            LoadDB();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FIO fio = new FIO();
            fio.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }
        private void SaveBD()
        {
            try
            {
                DataSet ds = new DataSet(); // создаем пока что пустой кэш данных
                DataTable dt = new DataTable(); // создаем пока что пустую таблицу данных
                dt.TableName = "TimeSheet"; // название таблицы
                dt.Columns.Add("Date");
                dt.Columns.Add("FIO");
                dt.Columns.Add("Stanok");
                dt.Columns.Add("WorkType");
                dt.Columns.Add("PartType");
                dt.Columns.Add("OfMachine");
                dt.Columns.Add("Amont");
                dt.Columns.Add("Units");
                ds.Tables.Add(dt); //в ds создается таблица, с названием и колонками, созданными выше

                foreach (DataGridViewRow r in dataGridView1.Rows) // пока в dataGridView1 есть строки
                {
                    DataRow row = ds.Tables["TimeSheet"].NewRow(); // создаем новую строку в таблице, занесенной в ds
                    row["Date"] = r.Cells[0].Value;  //в столбец этой строки заносим данные из первого столбца dataGridView1
                    row["FIO"] = r.Cells[1].Value; // то же самое со вторыми столбцами
                    row["Stanok"] = r.Cells[2].Value; // то же самое со вторыми столбцами
                    row["WorkType"] = r.Cells[3].Value; // то же самое со вторыми столбцами
                    row["PartType"] = r.Cells[4].Value; // то же самое со вторыми столбцами
                    row["OfMachine"] = r.Cells[5].Value; // то же самое со вторыми столбцами
                    row["Amont"] = r.Cells[6].Value; // то же самое со вторыми столбцами
                    row["Units"] = r.Cells[7].Value; //то же самое с третьими столбцами
                    ds.Tables["TimeSheet"].Rows.Add(row); //добавление всей этой строки в таблицу ds.
                }
                ds.WriteXml("C:/KEMZData/BD/TimeSheet1.xml");
                MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }
        }

        private void LoadDB()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\KEMZData\BD\TimeSheet.xml");
            foreach (DataRow item in ds.Tables["TimeSheet"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Date"];
                dataGridView1.Rows[n].Cells[1].Value = item["FIO"];
                dataGridView1.Rows[n].Cells[2].Value = item["Stanok"];
                dataGridView1.Rows[n].Cells[3].Value = item["WorkType"];
                dataGridView1.Rows[n].Cells[4].Value = item["PartType"];
                dataGridView1.Rows[n].Cells[5].Value = item["OfMachine"];
                dataGridView1.Rows[n].Cells[6].Value = item["Amont"];
                dataGridView1.Rows[n].Cells[7].Value = item["Units"];
            }
        }

        private void RefData(string name)
        {

        }
    }

}
