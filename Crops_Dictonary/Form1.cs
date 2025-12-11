using SQLitePCL;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using CropsDictonary.Core;


namespace Crops_Dictonary
{
    public partial class Form1 : Form
    {
        private readonly ICropService service;
        private BindingSource bindingSource = new BindingSource();

        public Form1(ICropService service)
        {
            InitializeComponent();
            this.service = service;
            bindingSource.DataSource = service.GetBindingList();
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;  
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[nameof(Crop.Name)].HeaderText = "Название";
            dataGridView1.Columns[nameof(Crop.Price)].HeaderText = "Цена за тонну";
            dataGridView1.Columns[nameof(Crop.Quantity)].HeaderText = "Количество тонн";
            dataGridView1.Columns[nameof(Crop.Name)].Width = 300;
            dataGridView1.BackgroundColor = Color.White;

            if (dataGridView1.Columns[nameof(Crop.Id)] != null)
            {
                dataGridView1.Columns[nameof(Crop.Id)].Visible = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Добавить запись";
            f.Width = 300;
            f.Height = 220;
            f.StartPosition = FormStartPosition.CenterParent;

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
                decimal.TryParse(t2.Text, out decimal price);
                decimal.TryParse((string)t3.Text, out decimal quantity);

                service.Add(t1.Text, price, quantity); 
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }

            Crop crop = dataGridView1.CurrentRow.DataBoundItem as Crop;
            if (crop == null) return;

            Form f = new Form();
            f.Text = "Редактировать запись";
            f.Width = 300;
            f.Height = 220;
            f.StartPosition = FormStartPosition.CenterParent;

            Label l1 = new Label() { Left = 10, Top = 20, Text = "Название" };
            TextBox t1 = new TextBox() { Left = 120, Top = 20, Width = 150, Text = crop.Name };

            Label l2 = new Label() { Left = 10, Top = 60, Text = "Цена" };
            TextBox t2 = new TextBox() { Left = 120, Top = 60, Width = 150, Text = crop.Price.ToString() };

            Label l3 = new Label() { Left = 10, Top = 100, Text = "Количество" };
            TextBox t3 = new TextBox() { Left = 120, Top = 100, Width = 150, Text = crop.Quantity.ToString() };

            Button ok = new Button() { Text = "ОК", Left = 100, Top = 140, Width = 80 };
            ok.DialogResult = DialogResult.OK;

            f.Controls.Add(l1); f.Controls.Add(t1);
            f.Controls.Add(l2); f.Controls.Add(t2);
            f.Controls.Add(l3); f.Controls.Add(t3);
            f.Controls.Add(ok);

            if (f.ShowDialog() == DialogResult.OK)
            {
                decimal.TryParse(t2.Text, out decimal price);
                decimal.TryParse((string)t3.Text, out decimal quantity);

                crop.Name = t1.Text;
                crop.Price = price;
                crop.Quantity = quantity;

                service.Edit(crop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!");
                return;
            }

            Crop crop = dataGridView1.CurrentRow.DataBoundItem as Crop;
            if (crop == null) return;

            DialogResult res = MessageBox.Show($"Удалить '{crop.Name}'?","Потверждение", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                service.Delete(crop);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}