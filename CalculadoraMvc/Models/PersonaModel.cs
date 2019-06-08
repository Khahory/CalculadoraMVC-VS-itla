using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalculadoraMvc.Models;

namespace CalculadoraMvc.Models
{
    public class PersonaModel
    {
        //variables de la tabla que tenemos en excel
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
    }
}