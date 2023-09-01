using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigadores.Shared.Entities
{
    public class Cientifico
    {

        public int Id { get; set; }

        public string Nombre { get; set; } = null;

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Apellido { get; set; } = null;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Afiliacion { get; set; } = null;

        [Required(ErrorMessage = "Debe especificar su afiliación")]
        public string Especializacion { get; set; } = null;

        [Required(ErrorMessage = "Debe especificar su especialización")]
        public string rol { get; set; } = null;

    }
    public class Colaborador
    {
        public string Id { get; set; }

        public string Nombre { get; set; } = null;

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Apellido { get; set; } = null;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Afiliacion { get; set; } = null;

        [Required(ErrorMessage = "Debe especificar su afiliación")]
        public string Especializacion { get; set; } = null;

        [Required(ErrorMessage = "Debe especificar su especialización")]
        public string rol { get; set; } = null;



    }
}
