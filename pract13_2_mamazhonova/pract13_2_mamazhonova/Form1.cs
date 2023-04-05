using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract13_2_mamazhonova
{
    public partial class Form1 : Form
    {
        private IList<Student> studlist = new List<Student>();
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;

        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.AutoResizeColumns();
        }

        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1==null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Имя";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }

        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Фамилия";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }

        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Зачетка";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }

        private void AddStudent(string name, string surname, string recordBookNumber)
        {
            Student s1 = new Student(name, surname, recordBookNumber);
            studlist.Add(s1);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            showListInGrid();

        }

        private void DeleteStudent(int elementIndex)
        {
            studlist.RemoveAt(elementIndex);
            showListInGrid();
        }

        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Student s1 in studlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = s1.GetName();
                cell2.ValueType = typeof(string);
                cell2.Value = s1.GetSurname();
                cell3.ValueType = typeof(string);
                cell3.Value = s1.GetRecordBookNumber();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                dataGridView1.Rows.Add(row);
            }
        }
        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить студента?","", MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes)
            {
                try
                {
                    DeleteStudent(selectedRow);
                }
                catch (Exception)
                {

                }

            }
        }
    }
}
