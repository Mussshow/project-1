namespace program_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Deduction = new System.Windows.Forms.TextBox();
            this.GrossIncome = new System.Windows.Forms.TextBox();
            this.Single = new System.Windows.Forms.RadioButton();
            this.Married = new System.Windows.Forms.RadioButton();
            this.TaxOwed = new System.Windows.Forms.TextBox();
            this.Adj_Gross = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Taxes_at37 = new System.Windows.Forms.TextBox();
            this.Taxes_at35 = new System.Windows.Forms.TextBox();
            this.Taxes_at32 = new System.Windows.Forms.TextBox();
            this.Taxes_at24 = new System.Windows.Forms.TextBox();
            this.Taxes_at22 = new System.Windows.Forms.TextBox();
            this.Taxes_at12 = new System.Windows.Forms.TextBox();
            this.Taxes_at10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.adj_income = new System.Windows.Forms.TextBox();
            this.Gross_income = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is the total Gross income: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "What is the total amount of deduction: ";
            // 
            // Deduction
            // 
            this.Deduction.Location = new System.Drawing.Point(263, 100);
            this.Deduction.Name = "Deduction";
            this.Deduction.Size = new System.Drawing.Size(100, 23);
            this.Deduction.TabIndex = 3;
            this.Deduction.TextChanged += new System.EventHandler(this.Deduction_TextChanged);
            // 
            // GrossIncome
            // 
            this.GrossIncome.Location = new System.Drawing.Point(263, 64);
            this.GrossIncome.Name = "GrossIncome";
            this.GrossIncome.Size = new System.Drawing.Size(100, 23);
            this.GrossIncome.TabIndex = 4;
            this.GrossIncome.TextChanged += new System.EventHandler(this.GrossIncome_TextChanged);
            // 
            // Single
            // 
            this.Single.AutoSize = true;
            this.Single.Location = new System.Drawing.Point(44, 29);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(57, 19);
            this.Single.TabIndex = 5;
            this.Single.TabStop = true;
            this.Single.Text = "Single";
            this.Single.UseVisualStyleBackColor = true;
            this.Single.CheckedChanged += new System.EventHandler(this.Single_CheckedChanged);
            // 
            // Married
            // 
            this.Married.AutoSize = true;
            this.Married.Location = new System.Drawing.Point(202, 29);
            this.Married.Name = "Married";
            this.Married.Size = new System.Drawing.Size(66, 19);
            this.Married.TabIndex = 6;
            this.Married.TabStop = true;
            this.Married.Text = "Married";
            this.Married.UseVisualStyleBackColor = true;
            this.Married.CheckedChanged += new System.EventHandler(this.Married_CheckedChanged);
            // 
            // TaxOwed
            // 
            this.TaxOwed.Location = new System.Drawing.Point(252, 363);
            this.TaxOwed.Name = "TaxOwed";
            this.TaxOwed.ReadOnly = true;
            this.TaxOwed.Size = new System.Drawing.Size(100, 23);
            this.TaxOwed.TabIndex = 7;
            this.TaxOwed.TextChanged += new System.EventHandler(this.TaxOwed_TextChanged);
            // 
            // Adj_Gross
            // 
            this.Adj_Gross.Location = new System.Drawing.Point(263, 138);
            this.Adj_Gross.Name = "Adj_Gross";
            this.Adj_Gross.ReadOnly = true;
            this.Adj_Gross.Size = new System.Drawing.Size(100, 23);
            this.Adj_Gross.TabIndex = 8;
            this.Adj_Gross.TextChanged += new System.EventHandler(this.Adj_Gross_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your adjuested income is:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tax at 10%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tax at 12%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tax at 22%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tax at 24%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tax at 32%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tax at 37%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tax at 35%";
            // 
            // Taxes_at37
            // 
            this.Taxes_at37.Location = new System.Drawing.Point(252, 323);
            this.Taxes_at37.Name = "Taxes_at37";
            this.Taxes_at37.ReadOnly = true;
            this.Taxes_at37.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at37.TabIndex = 17;
            // 
            // Taxes_at35
            // 
            this.Taxes_at35.Location = new System.Drawing.Point(252, 297);
            this.Taxes_at35.Name = "Taxes_at35";
            this.Taxes_at35.ReadOnly = true;
            this.Taxes_at35.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at35.TabIndex = 18;
            // 
            // Taxes_at32
            // 
            this.Taxes_at32.Location = new System.Drawing.Point(252, 273);
            this.Taxes_at32.Name = "Taxes_at32";
            this.Taxes_at32.ReadOnly = true;
            this.Taxes_at32.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at32.TabIndex = 19;
            // 
            // Taxes_at24
            // 
            this.Taxes_at24.Location = new System.Drawing.Point(252, 245);
            this.Taxes_at24.Name = "Taxes_at24";
            this.Taxes_at24.ReadOnly = true;
            this.Taxes_at24.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at24.TabIndex = 20;
            // 
            // Taxes_at22
            // 
            this.Taxes_at22.Location = new System.Drawing.Point(252, 220);
            this.Taxes_at22.Name = "Taxes_at22";
            this.Taxes_at22.ReadOnly = true;
            this.Taxes_at22.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at22.TabIndex = 21;
            // 
            // Taxes_at12
            // 
            this.Taxes_at12.Location = new System.Drawing.Point(252, 196);
            this.Taxes_at12.Name = "Taxes_at12";
            this.Taxes_at12.ReadOnly = true;
            this.Taxes_at12.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at12.TabIndex = 22;
            // 
            // Taxes_at10
            // 
            this.Taxes_at10.Location = new System.Drawing.Point(252, 171);
            this.Taxes_at10.Name = "Taxes_at10";
            this.Taxes_at10.ReadOnly = true;
            this.Taxes_at10.Size = new System.Drawing.Size(100, 23);
            this.Taxes_at10.TabIndex = 23;
            this.Taxes_at10.TextChanged += new System.EventHandler(this.Taxes_at10_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total taxes owed:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Taxes owed as % of Gross income:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Taxes owed as % of adjusted income:";
            // 
            // adj_income
            // 
            this.adj_income.Location = new System.Drawing.Point(252, 415);
            this.adj_income.Name = "adj_income";
            this.adj_income.ReadOnly = true;
            this.adj_income.Size = new System.Drawing.Size(100, 23);
            this.adj_income.TabIndex = 27;
            this.adj_income.TextChanged += new System.EventHandler(this.adj_income_TextChanged);
            // 
            // Gross_income
            // 
            this.Gross_income.Location = new System.Drawing.Point(252, 392);
            this.Gross_income.Name = "Gross_income";
            this.Gross_income.ReadOnly = true;
            this.Gross_income.Size = new System.Drawing.Size(100, 23);
            this.Gross_income.TabIndex = 28;
            this.Gross_income.TextChanged += new System.EventHandler(this.Gross_income_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "What is your filing Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Gross_income);
            this.Controls.Add(this.adj_income);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Taxes_at10);
            this.Controls.Add(this.Taxes_at12);
            this.Controls.Add(this.Taxes_at22);
            this.Controls.Add(this.Taxes_at24);
            this.Controls.Add(this.Taxes_at32);
            this.Controls.Add(this.Taxes_at35);
            this.Controls.Add(this.Taxes_at37);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Adj_Gross);
            this.Controls.Add(this.TaxOwed);
            this.Controls.Add(this.Married);
            this.Controls.Add(this.Single);
            this.Controls.Add(this.GrossIncome);
            this.Controls.Add(this.Deduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Yesi Tax Calculator 2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox Deduction;
        private TextBox GrossIncome;
        private RadioButton Single;
        private RadioButton Married;
        private TextBox TaxOwed;
        private TextBox Adj_Gross;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Taxes_at37;
        private TextBox Taxes_at35;
        private TextBox Taxes_at32;
        private TextBox Taxes_at24;
        private TextBox Taxes_at22;
        private TextBox Taxes_at12;
        private TextBox Taxes_at10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox adj_income;
        private TextBox Gross_income;
        private Label label14;
    }
}