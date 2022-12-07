namespace jatek_form
{
    partial class form_delete
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
            this.textBox1_studio = new System.Windows.Forms.TextBox();
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1_osszertek = new System.Windows.Forms.NumericUpDown();
            this.textBox1_jatekido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_osszertek)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_studio
            // 
            this.textBox1_studio.Location = new System.Drawing.Point(329, 171);
            this.textBox1_studio.Name = "textBox1_studio";
            this.textBox1_studio.Size = new System.Drawing.Size(84, 20);
            this.textBox1_studio.TabIndex = 55;
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(329, 94);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(84, 20);
            this.textBox1_nev.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Név:";
            // 
            // numericUpDown1_osszertek
            // 
            this.numericUpDown1_osszertek.DecimalPlaces = 2;
            this.numericUpDown1_osszertek.Location = new System.Drawing.Point(330, 206);
            this.numericUpDown1_osszertek.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1_osszertek.Name = "numericUpDown1_osszertek";
            this.numericUpDown1_osszertek.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_osszertek.TabIndex = 51;
            // 
            // textBox1_jatekido
            // 
            this.textBox1_jatekido.Location = new System.Drawing.Point(329, 133);
            this.textBox1_jatekido.Name = "textBox1_jatekido";
            this.textBox1_jatekido.Size = new System.Drawing.Size(84, 20);
            this.textBox1_jatekido.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Összértékelés(:/10):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Studió:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Játékidő(óra):";
            // 
            // list_adatok
            // 
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 0);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(120, 446);
            this.list_adatok.TabIndex = 46;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 28);
            this.button1.TabIndex = 56;
            this.button1.Text = "Adatok törlése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(330, 68);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(84, 20);
            this.textBox_id.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Id:";
            // 
            // form_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_studio);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1_osszertek);
            this.Controls.Add(this.textBox1_jatekido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_adatok);
            this.Name = "form_delete";
            this.Text = "form_delete";
            this.Load += new System.EventHandler(this.form_delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_osszertek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_studio;
        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1_osszertek;
        private System.Windows.Forms.TextBox textBox1_jatekido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label5;
    }
}