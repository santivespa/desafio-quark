using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.UiHelpers
{
    public class OpcionMenu
    {
        public int Opcion { get; set; }
        public string Texto { get; set; }

        public string TextoCompleto => $"{Opcion} - {Texto}";

        public OpcionMenu(int opcion, string texto)
        {
            this.Opcion = opcion;
            this.Texto = texto;
        }

        public OpcionMenu() { }


        public static List<OpcionMenu> ObtenerOpciones()
        {

            return new List<OpcionMenu>()
            {
                new OpcionMenu(1, "Hacer una cotización."),
                new OpcionMenu(2, "Historial de cotizaciones."),
            };
        }
    }



}
