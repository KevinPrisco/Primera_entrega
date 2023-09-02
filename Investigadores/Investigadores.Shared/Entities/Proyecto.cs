/*
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigadores.Shared.Entities
{
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
*/