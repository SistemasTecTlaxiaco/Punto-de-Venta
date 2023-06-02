using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projfinal
{
    internal class Producto
    {
        public int producto_id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
        public byte[] imagen { get; set; }
    }
}
