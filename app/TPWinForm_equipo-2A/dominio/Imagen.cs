using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class Imagen
    {
        public int ID { get; set; }
        public Articulo Articulo { get; set; }
        public string ImagenUrl { get; set; }
    }
}
