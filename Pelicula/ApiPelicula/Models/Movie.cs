using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiPelicula.Models
{
    public enum actores
    {
        Ian_McKellen,
        Elijah_Wood,
        Orlando_Bloom,
        Viggo_Mortensen,
        Dominic_Monaghan,
    }
    public class Movie
    {
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Ingrese titulo de 5 caracteres como minimo")]
        [Key]
        public string Titulo { get; set; }
        [StringLength(500, MinimumLength = 10)]
        public string Descripcion { get; set; } 
        [Required]
        public string Director { get; set; }
        public string Imagen { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public double Precio { get; set; }
        public actores Personajes { get; set; }




    }
}