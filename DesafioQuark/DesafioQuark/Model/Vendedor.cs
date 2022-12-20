using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Model
{
    internal class Vendedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Tienda Tienda { get; set; }

        public List<Cotizacion> Cotizaciones { get; set; } = new List<Cotizacion>();
    }
}
