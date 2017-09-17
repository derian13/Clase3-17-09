using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_2.Modelos
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DiadeCreacion { get; set; }
        public BaseEntity()
        {
            this.DiadeCreacion = DateTime.Now;
        }
    }
}
