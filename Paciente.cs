﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   public class Paciente: Persona//heredando la clase Persona
    {
        public int Id { get; set; }
        public string TipoPaciente { get; set; }
    }
}
