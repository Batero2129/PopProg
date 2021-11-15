using System;
using System.Data;
using System.Windows.Forms;

namespace PopProg
{
    public partial class TabelForm : Form
    {
        public TabelForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

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


        private void TabelForm_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
