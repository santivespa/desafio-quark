using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Model
{
    internal class Pantalon : Prenda
    {
        public TipoPantalon Tipo { get; set; }

        public bool EsComun()
        {
            return this.Tipo == TipoPantalon.Comun;
        }

        public bool EsChupin()
        {
            return this.Tipo == TipoPantalon.Chupin;
        }

        public enum TipoPantalon
        {
            Comun,
            Chupin
        }

        public override string TipoPrenda()
        {
            return "Pantalon";
        }

        public string ObtenerTipo()
        {
            return this.EsChupin() ? "chupin" : "comun";
        }
    }
}
