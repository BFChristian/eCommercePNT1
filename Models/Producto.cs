﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(30, ErrorMessage = "El nombre no puede exceder los 30 caracteres.")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(30, ErrorMessage = "La descripción no puede exceder los 30 caracteres.")]
        public string Descripcion { get; set; }


        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 10000, ErrorMessage = "El precio debe estar entre 0.01 y 10,000.")]
        public double Precio { get; set; }


        [Required(ErrorMessage = "El stock es obligatorio.")]
        [Range(0, 10000, ErrorMessage = "El stock no puede ser negativo y tampoco ser mayor a 10,000")]
        public int Stock { get; set; }
        /*
        public Producto(int id, string nombre, string descripcion, double precio, int stock)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }*/
    }
}
