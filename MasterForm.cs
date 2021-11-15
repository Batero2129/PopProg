using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PopProg
{
    public partial class MasterForm : Form
    {
        DataGridView inputDataGrid;
        string path = @"C:\KEMZData\BD\DataTable\WorkerList.txt";


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
            LoadWorkerList();
        }

        private void LoadWorkerList()
        {
            listBox1.Items.Clear();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
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

        private void SaveWorkersList()
        {
            try
            {
                if (listBox1.Items.Count > 1)
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(listBox1.Items[0]);
                    }

                    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.UTF8))
                    {
                        for (int i = 1; i < listBox1.Items.Count; i++)
                        {
                            sw.WriteLine(listBox1.Items[i]);
                        }
                    }
                }
                else if (listBox1.Items.Count == 1)
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(listBox1.Items[0]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Произошла какая-то ошибка!!!");
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

        public string[] TakeData()
        {
            int Lc = listBox1.Items.Count;
            string[] str = new string[Lc];
            for (int i = 0; i < Lc; i++)
            {
                str[i] = listBox1.Items[i].ToString();
            }

            return str;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            SaveWorkersList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            SaveWorkersList();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string diaPath = dialog.SelectedPath;
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            label1.Text = diaPath;
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
                ds.WriteXml(diaPath+@"\Kostikov "+month + "." + year +".xml");
                MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }

        }//Сгрузить
    }
}
