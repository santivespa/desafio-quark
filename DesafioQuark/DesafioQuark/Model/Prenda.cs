using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Model
{
    internal class Prenda
    {
        public int Codigo { get; set; }
        public CalidadPrenda Calidad { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }


        public bool EsPremium()
        {
            return this.Calidad == CalidadPrenda.Premium;
        }

        public bool EsStandard()
        {
            return this.Calidad == CalidadPrenda.Standard;
        }

        public virtual string TipoPrenda()
        {
            return "Prenda";
        }

        public string ObtenerCalidad()
        {
            return this.EsPremium() ? "premium" : "standard";
        }

        public enum CalidadPrenda
        {
            Standard,
            Premium
        }

        public decimal CalcularResultado(int cantidad)
        {
            decimal resultado = this.Precio * cantidad;

            if (this is Camisa)
            {
                var camisa = this as Camisa;
                if (camisa.EsMangaCorta())
                {
                    resultado -=  (resultado * Convert.ToDecimal(0.10));
                }
                if (camisa.TieneCuelloMao())
                {
                    resultado +=  (resultado * Convert.ToDecimal(0.03));
                }
            }
            else if (this is Pantalon)
            {
                var pantalon = this as Pantalon;
                if (pantalon.EsChupin())
                {
                    resultado -= (resultado * Convert.ToDecimal(0.12));
                }
            }

            if (this.EsPremium())
            {
                resultado +=  (resultado * Convert.ToDecimal(0.30));
            }
            return resultado;
        }
    }
}
