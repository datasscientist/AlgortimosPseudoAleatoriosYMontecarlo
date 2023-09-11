namespace Algortimos
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
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(639, 36);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 33);
            button1.TabIndex = 0;
            button1.Text = "Correr Prueba";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 298);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 193);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 301);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor de Chi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 22);
            label2.Name = "label2";
            label2.Size = new Size(220, 15);
            label2.TabIndex = 6;
            label2.Text = "Parametros Congruencial  Multiplicativo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 41);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 8;
            label3.Text = "a";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 39);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 68);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 10;
            label4.Text = "m";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 65);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 42);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 12;
            label5.Text = "Numeros a Generar";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(527, 42);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(84, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(411, 61);
            label6.Name = "label6";
            label6.Size = new Size(110, 12);
            label6.TabIndex = 13;
            label6.Text = "Nota: Máx 999 números";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 301);
            label7.Name = "label7";
            label7.Size = new Size(298, 15);
            label7.TabIndex = 14;
            label7.Text = "<-- Si el valor es menor a 16.92, entonces se rechaza H0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 45);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 15;
            label8.Text = "Ej. 1681";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 68);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 16;
            label9.Text = "Ej. 9973";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 338);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}