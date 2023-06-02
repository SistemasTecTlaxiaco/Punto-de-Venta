using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace projfinal
{
    public partial class Inventario : Form
    {
        private List<Producto> mProductos;
        private Producto mProducto;
        private ProductoConsultas mProductoConsultas;
        public Inventario()
        {
            InitializeComponent();
            mProductos = new List<Producto>();
            mProducto = new Producto();
            mProductoConsultas = new ProductoConsultas();

            cargarProductos();
        }

        private void cargarProductos(string filtro = "")
        {

            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.getProductos(filtro);

            for (int i = 0; i < mProductos.Count(); i++)
            {
                dgvProductos.RowTemplate.Height = Commun.ROW_HEIGTH;
                dgvProductos.Rows.Add(
                    mProductos[i].producto_id,
                    mProductos[i].nombre,
                    mProductos[i].precio,
                    mProductos[i].cantidad,
                    Image.FromStream(new MemoryStream(mProductos[i].imagen)));
            }
        }


        private void btregreso_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Show();
            this.Hide();
        }

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(textbuscar.Text.Trim());
        }

        private bool datosCorrectos()
        {
            // Validar el nombre del producto.
            if (textnombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return false;
            }

            // Validar el precio del producto
            if (textprecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el precio del producto");
                return false;
            }

            if (!float.TryParse(textprecio.Text.Trim(), out float precio))
            {
                MessageBox.Show("Ingrese un precio correcto");
                return false;
            }

            // Validar la cantidad del producto.
            if (textcantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad");
                return false;
            }


            if (!int.TryParse(textcantidad.Text.Trim(), out int cant))
            {
                MessageBox.Show("Ingrese una cantidad correcta");
                return false;
            }

            return true;
        }

        private void btagragar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
                return;

            CargarDatosProducto();

            if (mProductoConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado");
                cargarProductos();
                LimpiarDatosProducto();
            }
            else
                MessageBox.Show("Error al agregar el producto");
        }

        private void LimpiarDatosProducto()
        {
            textid.Text = "";
            textnombre.Text = "";
            textprecio.Text = "";
            textcantidad.Text = "";
            pbImage.Image = projfinal.Properties.Resources.agregar_imagen;
        }

        private void CargarDatosProducto()
        {
            mProducto.producto_id = getFolioIfExist();
            mProducto.nombre = textnombre.Text.Trim();
            mProducto.precio = float.Parse(textprecio.Text.Trim());
            mProducto.cantidad = int.Parse(textcantidad.Text.Trim());
            mProducto.imagen = ImageToByteArray(pbImage.Image);
        }

        private int getFolioIfExist()
        {
            if (!textid.Text.Trim().Equals(""))
            {
                if (int.TryParse(textid.Text.Trim(), out int folio))
                    return folio;
                else
                    return -1;
            }
            else
                return -1;
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;
            MemoryStream mMemoryStream = new MemoryStream();
            image.Save(mMemoryStream, ImageFormat.Png);
            return mMemoryStream.ToArray();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog.FileName;
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                textid.Text = Convert.ToString(fila.Cells["Folio"].Value);
                textnombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                textprecio.Text = Convert.ToString(fila.Cells["Precio"].Value);
                textcantidad.Text = Convert.ToString(fila.Cells["Cantidad"].Value);

                MemoryStream ms = new MemoryStream();
                Bitmap img = (Bitmap)dgvProductos.CurrentRow.Cells[4].Value;
                img.Save(ms, ImageFormat.Png);
                pbImage.Image = Image.FromStream(ms);
            }
            catch { }
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
                return;

            CargarDatosProducto();

            if (mProductoConsultas.modificarProducto(mProducto))
            {
                MessageBox.Show("Producto modificado");
                cargarProductos();
                LimpiarDatosProducto();
            }
            else
                MessageBox.Show("Error al modificar el producto");
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (getFolioIfExist() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿desea eliminar el producto?", "Eliminar Producto",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CargarDatosProducto();
                if (mProductoConsultas.eliminarProducto(mProducto))
                {
                    MessageBox.Show("Producto Eliminado");
                    cargarProductos();
                    LimpiarDatosProducto();
                }
            }

        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatosProducto();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            try
            {

                textid.Text = dataGridView1.CurrentRow.Cells["Folio"].Value.ToString();
                textnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textprecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();

                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                nudcantidadp.Text = Convert.ToString(fila.Cells["Cantidad"].Value);


                calcularsubtotal();

            }
            catch
            {

            }

            


        }

        

        private void calcularsubtotal()
        {

            int precio;
            int cantidad;

            if (!int.TryParse(textprecio.Text, out precio) || !int.TryParse(nudcantidadp.Text, out cantidad))
            {
                MessageBox.Show("Ingrese un precio y cantidad válidos");
                return;
            }

            if (precio < cantidad)
            {
                int subtotal = cantidad * precio;
                texttotal.Text = subtotal.ToString();
            }


        }

            private void btagragarproducto_Click(object sender, EventArgs e)
        {


            dataGridView1.Rows.Add(textid.Text, textnombre.Text, textprecio.Text, nudcantidadp.Text);


        }

        

        private void calculartotal()
        {
            /*decimal total = 0;

            if(dataGridView1.Rows.Count > 0) 
            {
                foreach (DataRow row in dataGridView1.Rows) 
                {
                    total + Convert.ToDecimal(dataGridView1.CurrentRow.Cells["SubTotal"].Value.InString());
                }
                texttotal.Text = total.ToString();
            }*/

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintPart.All);
                var w = Proper.ties.Resources.delete25.winth;
                var h = Proper.ties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Winth - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.handled = true;
            }
        }


    }
}
