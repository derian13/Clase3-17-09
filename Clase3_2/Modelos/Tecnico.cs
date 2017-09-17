using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_2.Modelos
{
    public class Tecnico:BaseEntity
    {
        [Required]//poner los string no null
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }//para poner la fecha como NULL
        public string Nacionalidad { get; set; }

        public ICollection<Materiales> Material { get; set; }

        public Tecnico():base() {
            this.Material = new HashSet<Materiales>();
        }
    }
}
