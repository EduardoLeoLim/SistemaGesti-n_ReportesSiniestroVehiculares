﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.modelo.poco
{
    /// <summary>
    /// Clase POCO 
    /// </summary>
    public class DelegacionTipo
    {
        private int idTipoDelegacion;
        private string tipoDelegacion;

        public DelegacionTipo()
        {
        }

        public int IdTipoDelegacion { get => idTipoDelegacion; set => idTipoDelegacion = value; }

        public string TipoDelegacion { get => tipoDelegacion; set => tipoDelegacion = value; }

        public override string ToString()
        {
            return tipoDelegacion;
        }
    }
}
