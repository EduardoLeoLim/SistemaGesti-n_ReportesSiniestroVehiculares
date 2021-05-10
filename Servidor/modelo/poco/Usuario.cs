﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.modelo.poco
{
    public class Usuario
    {
        private string username;
        private string nombreCompleto;
        private int idDelegacion;
        private string cargo;

        public string Username { get => username; set => username = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public Usuario()
        {

        }
    }
}