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
    public partial class MasterForm : Form
    {
        DataGridView inputDataGrid;

        public MasterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;


            LoadDB();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in inputDataGrid.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = inputDataGrid.Rows[item.Index].Cells[0].Value;
                dataGridView2.Rows[n].Cells[1].Value = inputDataGrid.Rows[item.Index].Cells[1].Value;
                dataGridView2.Rows[n].Cells[2].Value = inputDataGrid.Rows[item.Index].Cells[2].Value;
                dataGridView2.Rows[n].Cells[3].Value = inputDataGrid.Rows[item.Index].Cells[3].Value;
                dataGridView2.Rows[n].Cells[4].Value = inputDataGrid.Rows[item.Index].Cells[4].Value;
                dataGridView2.Rows[n].Cells[5].Value = inputDataGrid.Rows[item.Index].Cells[5].Value;
                dataGridView2.Rows[n].Cells[6].Value = inputDataGrid.Rows[item.Index].Cells[6].Value;
                dataGridView2.Rows[n].Cells[7].Value = inputDataGrid.Rows[item.Index].Cells[7].Value;
            }

            //dataGridView2.Rows.RemoveAt(dataGridView2.RowCount - 1);
            
        }

        private void LoadDB()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\KEMZData\BD\KostikovData.xml");
            foreach (DataRow item in ds.Tables["TimeSheet"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Date"];
                dataGridView1.Rows[n].Cells[1].Value = item["FIO"];
                dataGridView1.Rows[n].Cells[2].Value = item["Stanok"];
                dataGridView1.Rows[n].Cells[3].Value = item["WorkType"];
                dataGridView1.Rows[n].Cells[4].Value = item["PartType"];
                dataGridView1.Rows[n].Cells[5].Value = item["OfMachine"];
                dataGridView1.Rows[n].Cells[6].Value = item["Amount"];
                dataGridView1.Rows[n].Cells[7].Value = item["Units"];
            }
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
                dt.Columns.Add("Amount");
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
                    row["Amount"] = r.Cells[6].Value; // то же самое со вторыми столбцами
                    row["Units"] = r.Cells[7].Value; //то же самое с третьими столбцами
                    ds.Tables["TimeSheet"].Rows.Add(row); //добавление всей этой строки в таблицу ds.
                }
                ds.WriteXml("C:/KEMZData/BD/KostikovData.xml");
                MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }
        }

        public void InputData(DataGridView dataGridView)
        {
            inputDataGrid = dataGridView;
        }

        private void PlusData()
        {
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dataGridView2.Rows[item.Index].Cells[0].Value;
                dataGridView1.Rows[n].Cells[1].Value = dataGridView2.Rows[item.Index].Cells[1].Value;
                dataGridView1.Rows[n].Cells[2].Value = dataGridView2.Rows[item.Index].Cells[2].Value;
                dataGridView1.Rows[n].Cells[3].Value = dataGridView2.Rows[item.Index].Cells[3].Value;
                dataGridView1.Rows[n].Cells[4].Value = dataGridView2.Rows[item.Index].Cells[4].Value;
                dataGridView1.Rows[n].Cells[5].Value = dataGridView2.Rows[item.Index].Cells[5].Value;
                dataGridView1.Rows[n].Cells[6].Value = dataGridView2.Rows[item.Index].Cells[6].Value;
                dataGridView1.Rows[n].Cells[7].Value = dataGridView2.Rows[item.Index].Cells[7].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Принять
        {
            PlusData();
            dataGridView1.Update();
            dataGridView2.Rows.Clear();
            this.Close();
            SaveBD();
        }

        private void button2_Click(object sender, EventArgs e) //Удалить
        {
            if (dataGridView2.RowCount > 0) dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            else MessageBox.Show("Нечего удалять!");
        }
    }
}
