using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos.Shared.Entities
{
    internal class proyecto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }
        public string LiderProyecto { get; set; }
        public string descripcion { get; set; }
        public string AreaInvestigacion { get; set; }
    }
}
