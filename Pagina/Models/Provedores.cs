using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pagina.Models
{
    public class Provedores
    {
       
        public int Id { get; set; }
        [DisplayName("Nombre de la tienda")]
        public string Nombre { get; set; }
        [DisplayName("Tipo de tienda")]
        public string Tienda { get; set; }
        [DisplayName("Direccion Web")]
        public string url { get; set; }
    }
}