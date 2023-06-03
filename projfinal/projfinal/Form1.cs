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

namespace projfinal
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
                

        private void ingresar_Click(object sender, EventArgs e)
        {

            String email, password;
            email = usuario.Text;
            password = contraseña.Text;
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
            String sql = "select email, password from usuario2 where email ='" + email + "'AND password ='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido  " + email);
                Categoria cat = new Categoria();
                cat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contaseña Incorrecto");
            }

        }

        private void usuario_Leave(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                usuario.Text = "Ingresar Usuario";
                usuario.ForeColor = Color.Black;
            }
        }

        private void usuario_Enter(object sender, EventArgs e)
        {
            if (usuario.Text == "Ingresar Usuario")
            {
                usuario.Text = "";
                usuario.ForeColor = Color.Black;
            }
        }

        private void contraseña_Leave(object sender, EventArgs e)
        {
            if (contraseña.Text == "")
            {
                contraseña.Text = "Ingresar Contraseña";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = false;
            }
        }

        private void contraseña_Enter(object sender, EventArgs e)
        {
            if (contraseña.Text == "Ingresar Contraseña")
            {
                contraseña.Text = "";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void mostar_CheckedChanged(object sender, EventArgs e)
        {
            if (mostar.Checked == true)
            {
                contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            Registro f2 = new Registro();
            f2.Show();
            this.Hide();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
