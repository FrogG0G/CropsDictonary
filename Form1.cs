using System;
using System.Windows.Forms;

namespace Crops_Dictonary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Добавить запись";
            f.Width = 300;
            f.Height = 220;

            Label l1 = new Label() { Left = 10, Top = 20, Text = "Название" };
            TextBox t1 = new TextBox() { Left = 120, Top = 20, Width = 150 };

            Label l2 = new Label() { Left = 10, Top = 60, Text = "Цена" };
            TextBox t2 = new TextBox() { Left = 120, Top = 60, Width = 150 };

            Label l3 = new Label() { Left = 10, Top = 100, Text = "Количество" };
            TextBox t3 = new TextBox() { Left = 120, Top = 100, Width = 150 };

            Button ok = new Button() { Text = "ОК", Left = 100, Top = 140, Width = 80 };
            ok.DialogResult = DialogResult.OK;

            f.Controls.Add(l1); f.Controls.Add(t1);
            f.Controls.Add(l2); f.Controls.Add(t2);
            f.Controls.Add(l3); f.Controls.Add(t3);
            f.Controls.Add(ok);

            if (f.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(t1.Text, t2.Text, t3.Text);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Form f = new Form();
            f.Text = "Редактировать запись";
            f.Width = 300;
            f.Height = 220;

            Label l1 = new Label() { Left = 10, Top = 20, Text = "Название" };
            TextBox t1 = new TextBox() { Left = 120, Top = 20, Width = 150, Text = row.Cells[0].Value.ToString() };

            Label l2 = new Label() { Left = 10, Top = 60, Text = "Цена" };
            TextBox t2 = new TextBox() { Left = 120, Top = 60, Width = 150, Text = row.Cells[1].Value.ToString() };

            Label l3 = new Label() { Left = 10, Top = 100, Text = "Количество" };
            TextBox t3 = new TextBox() { Left = 120, Top = 100, Width = 150, Text = row.Cells[2].Value.ToString() };

            Button ok = new Button() { Text = "ОК", Left = 100, Top = 140, Width = 80 };
            ok.DialogResult = DialogResult.OK;

            f.Controls.Add(l1); f.Controls.Add(t1);
            f.Controls.Add(l2); f.Controls.Add(t2);
            f.Controls.Add(l3); f.Controls.Add(t3);
            f.Controls.Add(ok);

            if (f.ShowDialog() == DialogResult.OK)
            {
                row.Cells[0].Value = t1.Text;
                row.Cells[1].Value = t2.Text;
                row.Cells[2].Value = t3.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
                return;
            }

            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}