using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    internal class Plataforma
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Producto> Productos { get; set; }

        public Plataforma(List<Usuario> usuarios, List<Producto> productos)
        {
            Usuarios = usuarios;
            Productos = productos;
        }
    }
}
