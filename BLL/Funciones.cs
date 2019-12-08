using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class Funciones
    {
        /// <summary>
        /// Obtiene un mensaje, y si este contiene la palabra "éxito", entonces devuelve True, de lo contrario False
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool tipoMensaje(string mensaje)
        {
            if (mensaje.ToLower().Contains("éxito") || mensaje.ToLower().Contains("exito"))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Obtiene la cadena con el formato de la interfaz y la transforma en el formato que se puede guardar
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static string formatearFecha(string mensaje)
        {
            if(mensaje.Contains('/'))
            {
                string[] cadenaFecha = mensaje.Split('/');
                if (cadenaFecha.Length == 3)
                    return cadenaFecha[2] + '-' + cadenaFecha[1] + '-' + cadenaFecha[0];
                else
                    return "";
            }
            else
            {
                return "";
            }
        } 
    }
}
