using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Model
{
    internal class Cotizacion
    {
        public int Numero { get; set; }
        public Vendedor Vendedor { get; set; }
        public Prenda Prenda { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal Resultado { get; set; }



        public string ResultadoCompleto()
        {
            var resultado = $"{Prenda.TipoPrenda()}";

            if(Prenda is Camisa)
            {
                var camisa = Prenda as Camisa;
                resultado += $" de manga {camisa.ObtenerManga()} con cuello {camisa.ObtenerCuello()}";
            } 
            else if (Prenda is Pantalon)
            {
                var pantalon = Prenda as Pantalon;
                resultado += $" {pantalon.ObtenerTipo()}";
            }

            resultado += $" de calidad {Prenda.ObtenerCalidad()} es de ${this.Resultado}";

            return resultado;
        }
    }
}
