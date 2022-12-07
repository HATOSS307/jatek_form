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
    public partial class form_delete : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public form_delete()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_nev.Text))
            {
                MessageBox.Show("Adja meg a nevet");
                textBox1_nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1_studio.Text))
            {
                MessageBox.Show("Érvénytelen studió név");
                textBox1_studio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1_jatekido.Text))
            {
                MessageBox.Show("Érvénytelen jatékidő");
                textBox1_jatekido.Focus();
                return; ;
            }
            if (numericUpDown1_osszertek.Value < 0)
            {
                MessageBox.Show("Érnyénytelen összérték");
                numericUpDown1_osszertek.Focus();
                return;
            }
            cmd.CommandText = "DELETE FROM `ertekeles` WHERE  nev = @nev;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox1_nev.Text);
            cmd.Parameters.AddWithValue("@jatekido", textBox1_jatekido.Text);
            cmd.Parameters.AddWithValue("@studio", textBox1_jatekido.Text);
            cmd.Parameters.AddWithValue("@osszertek", numericUpDown1_osszertek.Value);
            connect.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres adat tölés");
                    textBox1_nev.Text = "";
                    textBox1_jatekido.Text = "";
                    textBox1_jatekido.Text = "";
                    numericUpDown1_osszertek.Value = numericUpDown1_osszertek.Minimum;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            connect.Close();
            jatek_update();
        }

        private void form_delete_Load(object sender, EventArgs e)
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
    }
}
