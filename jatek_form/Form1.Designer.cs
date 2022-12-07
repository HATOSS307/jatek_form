namespace jatek_form
{
    partial class Form_open
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
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1_osszertek = new System.Windows.Forms.NumericUpDown();
            this.textBox1_jatekido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rögzítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1_studio = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_osszertek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1_nev.Location = new System.Drawing.Point(329, 94);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.ReadOnly = true;
            this.textBox1_nev.Size = new System.Drawing.Size(84, 20);
            this.textBox1_nev.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Név:";
            // 
            // numericUpDown1_osszertek
            // 
            this.numericUpDown1_osszertek.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.numericUpDown1_osszertek.DecimalPlaces = 2;
            this.numericUpDown1_osszertek.Location = new System.Drawing.Point(330, 206);
            this.numericUpDown1_osszertek.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1_osszertek.Name = "numericUpDown1_osszertek";
            this.numericUpDown1_osszertek.ReadOnly = true;
            this.numericUpDown1_osszertek.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_osszertek.TabIndex = 41;
            // 
            // textBox1_jatekido
            // 
            this.textBox1_jatekido.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1_jatekido.Location = new System.Drawing.Point(329, 133);
            this.textBox1_jatekido.Name = "textBox1_jatekido";
            this.textBox1_jatekido.ReadOnly = true;
            this.textBox1_jatekido.Size = new System.Drawing.Size(84, 20);
            this.textBox1_jatekido.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Összértékelés(:/10):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Studió:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Játékidő(óra):";
            // 
            // list_adatok
            // 
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 24);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(120, 424);
            this.list_adatok.TabIndex = 35;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rögzítésToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rögzítésToolStripMenuItem
            // 
            this.rögzítésToolStripMenuItem.Name = "rögzítésToolStripMenuItem";
            this.rögzítésToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rögzítésToolStripMenuItem.Text = "Rögzítés";
            this.rögzítésToolStripMenuItem.Click += new System.EventHandler(this.rögzítésToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // textBox1_studio
            // 
            this.textBox1_studio.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1_studio.Location = new System.Drawing.Point(329, 171);
            this.textBox1_studio.Name = "textBox1_studio";
            this.textBox1_studio.ReadOnly = true;
            this.textBox1_studio.Size = new System.Drawing.Size(84, 20);
            this.textBox1_studio.TabIndex = 45;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(329, 60);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(84, 20);
            this.textBox_id.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Id:";
            // 
            // Form_open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 448);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_studio);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1_osszertek);
            this.Controls.Add(this.textBox1_jatekido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_adatok);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_open";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_open_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_osszertek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1_osszertek;
        private System.Windows.Forms.TextBox textBox1_jatekido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rögzítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1_studio;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label5;
    }
}

