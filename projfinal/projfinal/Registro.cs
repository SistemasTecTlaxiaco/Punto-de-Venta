using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace projfinal
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, System.EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost; database=proyec_final; User id=root;");

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "insert into usuario2(email,password) values ('" + usuario2.Text + "','" + contraseña2.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRADO");
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void cerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
