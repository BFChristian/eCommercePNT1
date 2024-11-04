using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    internal class Compra

    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public List<Producto> Productos { get; set; }
        public string FechaCompra { get; set; }

        public Compra(int id, Usuario usuario, List<Producto> productos, string fechaCompra)
        {
            Id = id;
            Usuario = usuario;
            Productos = productos;
            FechaCompra = fechaCompra;
        }
        
    }
}
