using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Model
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Prenda> Prendas { get; set; } = new List<Prenda>();
        public List<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        internal Prenda? BuscarPrenda(string? codigoPrenda)
        {
            int codigoInt;
            if (!int.TryParse(codigoPrenda, out codigoInt))
            {
                return null;
            }
            return this.Prendas.FirstOrDefault(x => x.Codigo == codigoInt);
        }
    }
}
