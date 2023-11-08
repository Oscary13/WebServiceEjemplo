using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebServiceEjemplo.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int ID { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set;}

        public string CantidadStock { get; set;}

        public string CantidadVendido { get; set; }
    }

    public class ProductoDTO
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public string CantidadStock { get; set; }

        public string CantidadVendido { get; set; }
    }
}