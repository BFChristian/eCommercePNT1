using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Carrito Carrito { get; set; }
        public List<Compra> Compras { get; set; }

        public Usuario(int id, string nombre, Carrito carrito, List<Compra> compras)
        {
            Id = id;
            Nombre = nombre;
            Carrito = carrito;
            Compras = compras;
        }
        
    }
}
