using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AutoNegocio
    {
        public List<Auto> ListarAutos()
        {
            List<Auto> list = new List<Auto>();
            list.Add(new Auto(1, "Golf", "Elegante y Deportivo", "Blanco", DateTime.Now, true, true));
            list.Add(new Auto(2, "Cruze", "Sedan", "Negro", DateTime.Now, false, false));
            return list;
        }

        public static bool ValidarCampo(string texto)
        {
            if(!string.IsNullOrWhiteSpace(texto) || !Regex.Match(texto, "^[a-zA-Z ]*$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarFecha(DateTime date)
        {
            return date > DateTime.Now ? false : true;
        }

        public static int ValidarNumero(string n)
        {
            if(int.TryParse(n, out int numero) && numero > 2)
            {
                return numero;
            }
            return new Random().Next(3,5000);
        }
    }
}
