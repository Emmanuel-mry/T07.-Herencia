﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medico: Persona//heredando la clase Persona
    {
        public int Id { get; set; }
        public string Area { get; set; }
    }
}