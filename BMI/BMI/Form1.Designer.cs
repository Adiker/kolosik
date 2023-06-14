namespace kolokwium
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
            woman = new RadioButton();
            man = new RadioButton();
            label2 = new Label();
            wiek = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            wzrost = new NumericUpDown();
            label5 = new Label();
            waga = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lista = new ComboBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)wiek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wzrost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 8);
            label1.Name = "label1";
            label1.Size = new Size(326, 29);
            label1.TabIndex = 0;
            label1.Text = "Obliczanie BMI, PPM i CPM";
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            woman.Location = new Point(204, 71);
            woman.Margin = new Padding(3, 2, 3, 2);
            woman.Name = "woman";
            woman.Size = new Size(33, 18);
            woman.TabIndex = 1;
            woman.TabStop = true;
            woman.Text = "K";
            woman.UseVisualStyleBackColor = true;
            // 
            // man
            // 
            man.AutoSize = true;
            man.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            man.Location = new Point(243, 71);
            man.Margin = new Padding(3, 2, 3, 2);
            man.Name = "man";
            man.Size = new Size(35, 18);
            man.TabIndex = 2;
            man.TabStop = true;
            man.Text = "M";
            man.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 71);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 3;
            label2.Text = "Podaj płeć:";
            // 
            // wiek
            // 
            wiek.Location = new Point(214, 101);
            wiek.Margin = new Padding(3, 2, 3, 2);
            wiek.Name = "wiek";
            wiek.Size = new Size(131, 20);
            wiek.TabIndex = 5;
            wiek.ValueChanged += wiek_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 102);
            label3.Name = "label3";
            label3.Size = new Size(81, 14);
            label3.TabIndex = 6;
            label3.Text = "Podaj wiek:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 173);
            label4.Name = "label4";
            label4.Size = new Size(95, 14);
            label4.TabIndex = 11;
            label4.Text = "Podaj wzrost:";
            // 
            // wzrost
            // 
            wzrost.Location = new Point(214, 173);
            wzrost.Margin = new Padding(3, 2, 3, 2);
            wzrost.Name = "wzrost";
            wzrost.Size = new Size(131, 20);
            wzrost.TabIndex = 10;
            wzrost.ValueChanged += wzrost_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(113, 135);
            label5.Name = "label5";
            label5.Size = new Size(87, 14);
            label5.TabIndex = 9;
            label5.Text = "Podaj wagę:";
            // 
            // waga
            // 
            waga.Location = new Point(214, 135);
            waga.Margin = new Padding(3, 2, 3, 2);
            waga.Name = "waga";
            waga.Size = new Size(131, 20);
            waga.TabIndex = 12;
            waga.ValueChanged += waga_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(350, 101);
            label6.Name = "label6";
            label6.Size = new Size(54, 14);
            label6.TabIndex = 13;
            label6.Text = "(18-99)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(351, 137);
            label7.Name = "label7";
            label7.Size = new Size(22, 14);
            label7.TabIndex = 14;
            label7.Text = "kg";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(351, 180);
            label8.Name = "label8";
            label8.Size = new Size(24, 14);
            label8.TabIndex = 15;
            label8.Text = "cm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(146, 213);
            label9.Name = "label9";
            label9.Size = new Size(189, 14);
            label9.TabIndex = 16;
            label9.Text = "Poziom aktywności fizycznej:";
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.Items.AddRange(new object[] { "Brak aktywności", "Bardzo lekka aktywność (1 dzień w tygodniu)", "Lekka aktywność (2-3 dni w tygodniu)", "Średnia aktywność (4-5 dni w tygodniu)", "Duża aktywność (codziennie)", "Bardzo duża aktywność" });
            lista.Location = new Point(156, 229);
            lista.Margin = new Padding(3, 2, 3, 2);
            lista.Name = "lista";
            lista.Size = new Size(174, 21);
            lista.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(176, 264);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 18;
            button1.Text = "Oblicz dane";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(382, 264);
            label10.Name = "label10";
            label10.Size = new Size(101, 26);
            label10.TabIndex = 19;
            label10.Text = "Adam Wandelt\r\n148950";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(495, 304);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(lista);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(waga);
            Controls.Add(label4);
            Controls.Add(wzrost);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(wiek);
            Controls.Add(label2);
            Controls.Add(man);
            Controls.Add(woman);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wiek).EndInit();
            ((System.ComponentModel.ISupportInitialize)wzrost).EndInit();
            ((System.ComponentModel.ISupportInitialize)waga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton woman;
        private RadioButton man;
        private Label label2;
        private NumericUpDown wiek;
        private Label label3;
        private Label label4;
        private NumericUpDown wzrost;
        private Label label5;
        private NumericUpDown waga;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox lista;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label10;
    }
}