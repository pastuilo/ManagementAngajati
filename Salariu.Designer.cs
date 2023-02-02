
namespace ManagementAngajati
{
    partial class Salariu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salariu));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AfisSalariu = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZileMunciteSal = new System.Windows.Forms.TextBox();
            this.PozitieAngajatTbSal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeAngajatTbSal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdAngajatTbSal = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(29, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Calculare Salariu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AfisSalariu);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ZileMunciteSal);
            this.panel1.Controls.Add(this.PozitieAngajatTbSal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NumeAngajatTbSal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IdAngajatTbSal);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(-4, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 630);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1359, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "Printeaza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AfisSalariu
            // 
            this.AfisSalariu.BackColor = System.Drawing.Color.OrangeRed;
            this.AfisSalariu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AfisSalariu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AfisSalariu.ForeColor = System.Drawing.Color.White;
            this.AfisSalariu.Location = new System.Drawing.Point(470, 43);
            this.AfisSalariu.Name = "AfisSalariu";
            this.AfisSalariu.ReadOnly = true;
            this.AfisSalariu.Size = new System.Drawing.Size(834, 496);
            this.AfisSalariu.TabIndex = 29;
            this.AfisSalariu.Text = "";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(216, 507);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 50);
            this.button5.TabIndex = 28;
            this.button5.Text = "Vizualizare";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(89, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 50);
            this.button4.TabIndex = 26;
            this.button4.Text = "Acasa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(211, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 48);
            this.button3.TabIndex = 25;
            this.button3.Text = "Preparare Date";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(30, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pozitie Angajat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(30, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zile Muncite";
            // 
            // ZileMunciteSal
            // 
            this.ZileMunciteSal.BackColor = System.Drawing.Color.OrangeRed;
            this.ZileMunciteSal.Location = new System.Drawing.Point(30, 390);
            this.ZileMunciteSal.Name = "ZileMunciteSal";
            this.ZileMunciteSal.Size = new System.Drawing.Size(147, 21);
            this.ZileMunciteSal.TabIndex = 13;
            // 
            // PozitieAngajatTbSal
            // 
            this.PozitieAngajatTbSal.BackColor = System.Drawing.Color.OrangeRed;
            this.PozitieAngajatTbSal.FormattingEnabled = true;
            this.PozitieAngajatTbSal.Items.AddRange(new object[] {
            "Manager",
            "Developer Senior",
            "Developer Junior",
            "Contabil",
            "Receptionist"});
            this.PozitieAngajatTbSal.Location = new System.Drawing.Point(30, 276);
            this.PozitieAngajatTbSal.Name = "PozitieAngajatTbSal";
            this.PozitieAngajatTbSal.Size = new System.Drawing.Size(147, 23);
            this.PozitieAngajatTbSal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(30, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nume Angajat";
            // 
            // NumeAngajatTbSal
            // 
            this.NumeAngajatTbSal.BackColor = System.Drawing.Color.OrangeRed;
            this.NumeAngajatTbSal.Location = new System.Drawing.Point(30, 173);
            this.NumeAngajatTbSal.Name = "NumeAngajatTbSal";
            this.NumeAngajatTbSal.Size = new System.Drawing.Size(147, 21);
            this.NumeAngajatTbSal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID Angajat";
            // 
            // IdAngajatTbSal
            // 
            this.IdAngajatTbSal.BackColor = System.Drawing.Color.OrangeRed;
            this.IdAngajatTbSal.Location = new System.Drawing.Point(30, 66);
            this.IdAngajatTbSal.Name = "IdAngajatTbSal";
            this.IdAngajatTbSal.Size = new System.Drawing.Size(108, 21);
            this.IdAngajatTbSal.TabIndex = 7;
            this.IdAngajatTbSal.TextChanged += new System.EventHandler(this.IdAngajatTbSal_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Salariu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1503, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salariu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salariu";
            this.Load += new System.EventHandler(this.Salariu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZileMunciteSal;
        private System.Windows.Forms.ComboBox PozitieAngajatTbSal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeAngajatTbSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdAngajatTb;
        private System.Windows.Forms.RichTextBox AfisSalariu;
        private System.Windows.Forms.TextBox IdAngajatTbSal;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}