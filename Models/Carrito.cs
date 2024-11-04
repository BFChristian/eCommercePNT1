using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    internal class Carrito
    {
        public List<Producto> Productos { get; set; }
        public Usuario Usuario { get; set; }

        public Carrito(List<Producto> productos, Usuario usuario)
        {
            Productos = productos;
            Usuario = usuario;
        }
    }
}
