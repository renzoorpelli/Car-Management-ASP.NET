using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
