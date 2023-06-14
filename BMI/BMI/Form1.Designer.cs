namespace BMI
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
            this.label1 = new System.Windows.Forms.Label();
            this.kobieta = new System.Windows.Forms.RadioButton();
            this.mezczyzna = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "K A L K U L A T O R                   B M I";
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.Location = new System.Drawing.Point(323, 96);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(39, 24);
            this.kobieta.TabIndex = 1;
            this.kobieta.TabStop = true;
            this.kobieta.Text = "K";
            this.kobieta.UseVisualStyleBackColor = true;
            // 
            // mezczyzna
            // 
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.Location = new System.Drawing.Point(368, 96);
            this.mezczyzna.Name = "mezczyzna";
            this.mezczyzna.Size = new System.Drawing.Size(43, 24);
            this.mezczyzna.TabIndex = 2;
            this.mezczyzna.TabStop = true;
            this.mezczyzna.Text = "M";
            this.mezczyzna.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj płeć:";
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(323, 155);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(150, 27);
            this.wiek.TabIndex = 5;
            this.wiek.ValueChanged += new System.EventHandler(this.wiek_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Podaj wiek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Podaj wzrost:";
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(325, 264);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(150, 27);
            this.wzrost.TabIndex = 10;
            this.wzrost.ValueChanged += new System.EventHandler(this.wzrost_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Podaj wagę:";
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(323, 205);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(150, 27);
            this.waga.TabIndex = 12;
            this.waga.ValueChanged += new System.EventHandler(this.waga_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(18-99)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Poziom aktywności fizycznej:";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "Brak aktywności",
            "Bardzo lekka aktywność (1 dzień w tygodniu)",
            "Lekka aktywność (2-3 dni w tygodniu)",
            "Średnia aktywność (4-5 dni w tygodniu)",
            "Duża aktywność (codziennie)",
            "Bardzo duża aktywność"});
            this.lista.Location = new System.Drawing.Point(275, 331);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(198, 28);
            this.lista.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Zapisz i oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mezczyzna);
            this.Controls.Add(this.kobieta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton kobieta;
        private RadioButton mezczyzna;
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
    }
}