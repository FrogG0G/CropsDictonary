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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            add = new Button();
            edit = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 120);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(621, 440);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // add
            // 
            add.Location = new Point(22, 61);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Size = new Size(86, 31);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // edit
            // 
            edit.Location = new Point(114, 61);
            edit.Margin = new Padding(3, 4, 3, 4);
            edit.Name = "edit";
            edit.Size = new Size(121, 31);
            edit.TabIndex = 2;
            edit.Text = "Редактировать";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(242, 61);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(86, 31);
            delete.TabIndex = 3;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            delete.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Crops Dictonary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button add;
        private Button edit;
        private Button delete;
    }
}
