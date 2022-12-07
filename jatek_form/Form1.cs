using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek_form
{
    public partial class Form_open : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public Form_open()
        {
            InitializeComponent();
        }
        public void jatek_update()
        {
            list_adatok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`jatekido`,`studio`,`osszertek` FROM `ertekeles`";
            connect.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                   jatekok uj = new jatekok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("jatekido"), dr.GetString("studio"), dr.GetDouble("osszertek"));
                    list_adatok.Items.Add(uj);
                }
            }
            connect.Close();
        }

        private void Form_open_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "jatekok";
            connect = new MySqlConnection(builder.ConnectionString);
            try
            {
                //terv szerint
                connect.Open();
                cmd = connect.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //terv megbukott
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leált");
                Environment.Exit(0);
            }
            finally
            {
                connect.Close();
            }
            jatek_update();
        
        }

        private void rögzítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_New.ShowDialog();
            jatek_update();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Edit.ShowDialog();
            jatek_update();

        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_Delete.ShowDialog();
            jatek_update();
        }

        private void list_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_adatok.SelectedIndex < 0)
            {
                return;
            }
            jatekok kivalasztott_adat = (jatekok)list_adatok.SelectedItem;
            textBox_id.Text = kivalasztott_adat.Id.ToString();
            textBox1_nev.Text = kivalasztott_adat.Nev.ToString();
            textBox1_jatekido.Text = kivalasztott_adat.Jatekido.ToString();
            textBox1_studio.Text = kivalasztott_adat.Studio.ToString(); ;
            numericUpDown1_osszertek.Value = Convert.ToDecimal(kivalasztott_adat.Osszertekertekeles);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
