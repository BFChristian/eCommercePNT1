using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }
        public DateTime FechaCompra { get; set; }

        /*
        public Compra(int id, Usuario usuario, List<Producto> productos, string fechaCompra)
        {
            Id = id;
            Usuario = usuario;
            Productos = productos;
            FechaCompra = fechaCompra;
        }
        */
        
    }
}
