namespace Lesson19_winform
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
            label1 = new Label();
            txtName = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtSurname = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumOrchid;
            label1.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 28);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 0;
            label1.Text = "Adiniz";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 55);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 30);
            txtName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(160, 184);
            button1.Name = "button1";
            button1.Size = new Size(142, 52);
            button1.TabIndex = 2;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkViolet;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(491, 164);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(110, 123);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(255, 30);
            txtSurname.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumOrchid;
            label2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 96);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 4;
            label2.Text = "Soyadiniz";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(110, 159);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 454);
            Controls.Add(checkBox1);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtSurname;
        private Label label2;
        private CheckBox checkBox1;
    }
}