﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controllers.Map
{
    class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {

        }
    }
}