﻿using DelegacionMunicipal.conexion;
using DelegacionMunicipal.modelo.poco;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DelegacionMunicipal.modelo.dao
{
    /// <summary>
    /// DAO para obtener municipios
    /// </summary>
    
    public class MunicipioDAO
    {
        public static List<Municipio> ConsultarMunicipios()
        {
            List<Municipio> listaMunicipios = new List<Municipio>();
            SocketBD socket = new SocketBD();
            string mensaje = "";
            Paquete paquete = new Paquete();
            paquete.Consulta = "SELECT idMunicipio, nombre FROM dbo.municipio";
            paquete.TipoDominio = TipoDato.Municipio;
            paquete.TipoQuery = TipoConsulta.Select;

            mensaje = JsonSerializer.Serialize(paquete);

            socket.IniciarConexion();
            socket.EnviarMensaje(mensaje);
            string respuesta = socket.RecibirMensaje();
            socket.TerminarConexion();

            if (respuesta.Length > 0)
            {
                listaMunicipios = (List<Municipio>)JsonSerializer.Deserialize(respuesta, typeof(List<Municipio>)); ;
            }

            return listaMunicipios;
        }
    }
}
