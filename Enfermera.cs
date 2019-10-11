using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   public class Enfermera: Persona//heredando la clase Persona
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public string Horario { get; set; }
    }
}
