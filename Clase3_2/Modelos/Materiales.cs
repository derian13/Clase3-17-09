using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_2.Modelos
{
    public class Materiales:BaseEntity
    {
        public int CantidadUtilizada { get; set; }
        public string Nombre { get; set; }
        public string CodigoMaterial { get; set; }
        public int CantidadSalida { get; set; }
        public string Stock { get; set; }

        [ForeignKey("Tecnico")]
        public int TecnicoId { get; set; }
        public virtual Tecnico Tecnico { get; set; }

        public ICollection<Categoria> Categorias { get; set; }

        public Materiales() : base()
        {
            this.Categorias = new HashSet<Categoria>();
        }


    }
}
