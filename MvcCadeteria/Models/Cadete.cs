// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace MvcCadeteria.Models
// {
//     public class Cadete
//     {
        
//     }
// }
using System.ComponentModel.DataAnnotations;

namespace MvcCadeteria.Models
{
    public class Cadete
    {
        // public int Id { get; set; }
        // public string? Title { get; set; }

        // [DataType(DataType.Date)]
        // public DateTime ReleaseDate { get; set; }
        // public string? Genre { get; set; }
        // public decimal Price { get; set; }
        public int id {get; set;}
        public string? nombre {get; set;}
        public string? calle {get; set;}
        public int numero {get; set;}
        public string? telefono {get; set;}
    }
}