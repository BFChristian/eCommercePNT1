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


        [Required(ErrorMessage = "El ID del usuario es obligatorio.")]
        public int UsuarioId { get; set; }


        [Required(ErrorMessage = "El usuario es obligatorio.")]
        public Usuario? Usuario { get; set; }


        [Required(ErrorMessage = "El ID del producto es obligatorio.")]
        public int ProductoId { get; set; }


        [Required(ErrorMessage = "El producto es obligatorio.")]
        public Producto? Producto { get; set; }


        [Required(ErrorMessage = "La fecha de compra es obligatoria.")]
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
