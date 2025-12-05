namespace Crops_Dictonary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            add = new Button();
            edit = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, price, quantity });
            dataGridView1.Location = new Point(19, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 330);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "Название";
            name.Name = "name";
            name.Width = 300;
            // 
            // price
            // 
            price.HeaderText = "Цена за тонну";
            price.Name = "price";
            // 
            // quantity
            // 
            quantity.HeaderText = "Количество тонн";
            quantity.Name = "quantity";
            // 
            // add
            // 
            add.Location = new Point(19, 46);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.Location = new Point(100, 46);
            edit.Name = "edit";
            edit.Size = new Size(106, 23);
            edit.TabIndex = 2;
            edit.Text = "Редактировать";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(212, 46);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 3;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button add;
        private Button edit;
        private Button delete;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
    }
}
