using System;
using System.Data;
using System.Windows.Forms;


//--  @"C:\KEMZData\BD\DataTable\FilesOfDvig\АВРМ132М2.xml"



namespace PopProg
{
    public partial class NewWork : Form
    {
        public NewWork()
        {
            InitializeComponent();

            LoadDB_PartList();
            LoadDB_FilesOfDvig();

            AddNameOfDvigInComboBox();

        }

        private void AddNameOfDvigInComboBox()
        {
            foreach ( DataGridViewRow item in dataGridView_FilePath.Rows)
            {
                comboBox1.Items.Add(item.Cells[0].Value);
            }
        }

        private void LoadDB_PartList()
        {

        }

        private void LoadDB_FilesOfDvig()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\KEMZData\BD\DataTable\ListOfFiles.xml");
            foreach (DataRow item in dataSet.Tables["FilesInclude"].Rows)
            {
                int n = dataGridView_FilePath.Rows.Add();
                dataGridView_FilePath.Rows[n].Cells[0].Value = item["FileNameOfDvig"];
                dataGridView_FilePath.Rows[n].Cells[1].Value = item["FilePathOfDvig"];

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewDvigForm addNewDvigForm = new AddNewDvigForm();
            addNewDvigForm.ShowDialog();
        }
    }

}
