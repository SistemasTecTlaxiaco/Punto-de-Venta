using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projfinal
{
    internal class ProductoConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Producto> mProductos;

        public ProductoConsultas()
        {
            conexionMySql = new ConexionMySql();
            mProductos = new List<Producto>();
        }


        public List<Producto> getProductos(string filtro)
        {
            string QUERY = "SELECT * FROM producto";

            MySqlDataReader mReader = null;
            Producto mProducto;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "producto_id LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "precio LIKE '%" + filtro + "%' OR " +
                        "cantidad LIKE '%" + filtro + "%';";
                }

                MySqlCommand mCommand = new MySqlCommand(QUERY);
                mCommand.Connection = conexionMySql.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mProducto = new Producto();
                    mProducto.producto_id = mReader.GetInt16("producto_id");
                    mProducto.nombre = mReader.GetString("nombre");
                    mProducto.precio = mReader.GetInt16("precio");
                    mProducto.cantidad = mReader.GetInt16("cantidad");
                    mProducto.imagen = (byte[])mReader.GetValue(4);
                    mProductos.Add(mProducto);
                }
                mReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionMySql.closeConexion();
            }

            return mProductos;
        }

        public bool agregarProducto(Producto mProducto)
        {
            string INSERT = "INSERT INTO producto (nombre, precio, cantidad, imagen)" + " values (@nombre, @precio, @cantidad, @imagen);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySql.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@imagen", mProducto.imagen));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarProducto(Producto mProducto)
        {
            string UPDATE = " UPDATE producto " +
                "SET nombre = @nombre, " +
                "precio = @precio, " +
                "cantidad = @cantidad, " +
                "imagen = @imagen " +
                "WHERE producto_id  = @producto_id ";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySql.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@nombre", mProducto.nombre));
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
            mCommand.Parameters.Add(new MySqlParameter("@cantidad", mProducto.cantidad));
            mCommand.Parameters.Add(new MySqlParameter("@imagen", mProducto.imagen));
            mCommand.Parameters.Add(new MySqlParameter("@producto_id", mProducto.producto_id));

            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarProducto(Producto mProducto)
        {
            string DELETE = " DELETE FROM producto WHERE producto_id =@producto_id ";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySql.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@producto_id", mProducto.producto_id));
            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
