using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_2.Modelos
{
    public class Categoria:BaseEntity
    {
        public string Nombre { get; set; }

        public ICollection<Materiales> material { get; set; }

        public Categoria() : base()
        {
            this.material = new HashSet<Materiales>();
        }
    }
}
