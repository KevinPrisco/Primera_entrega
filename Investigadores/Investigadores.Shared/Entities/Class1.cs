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
    public class Proyecto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "El nombre es requerido")]
        public string fechaInicio { get; set; } = string.Empty;
        public string fechaFinal { get; set; } = string.Empty;
        public string LiderProyecto { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public string AreaInvestigacion { get; set; } = string.Empty;
    }
}
