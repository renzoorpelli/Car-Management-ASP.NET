using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Auto
    {
        private int id;
        private string modelo;
        private string descripcion;
        private string color;
        private DateTime fecha;
        private bool esUsado;
        private bool importado;

        public Auto(int id, string modelo, string descripcion, string color, DateTime fecha, bool esUsado, bool importado)
        {
            this.id = id;
            this.modelo = modelo;
            this.descripcion = descripcion;
            this.color = color;
            this.fecha = fecha;
            this.esUsado = esUsado;
            this.importado = importado;
        }

        public int Id { get => id; set => id = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Color { get => color; set => color = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool EsUsado { get => esUsado; set => esUsado = value; }
        public bool Importado { get => importado; set => importado = value; }
    }
}
