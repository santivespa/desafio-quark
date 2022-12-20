using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesafioQuark.Data;
using DesafioQuark.Model;
using DesafioQuark.UiHelpers;


namespace DesafioQuark
{
    public static class Controlador
    {

        private readonly static List<OpcionMenu> opcionesMenu = OpcionMenu.ObtenerOpciones();
        private readonly static Tienda tienda = DataHelper.CargarTienda();
        private readonly static Vendedor vendedor = DataHelper.CargarVendedor();

        public static void CorrerPrograma()
        {
            tienda.Vendedores.Add(vendedor);
            MostrarMenu();

        }

        private static void MostrarMenu()
        {
         
            Vista.WriteLine("Menu:");

            foreach (var opcion in opcionesMenu)
            {
                Vista.WriteLine(opcion.TextoCompleto);
            }

            Vista.Write("Ingresar una opción: ");
            var opcionSeleccionada = Vista.ReadLine();
            while (!ValidarOpcion(opcionSeleccionada))
            {
                Vista.Write("Opción invalida, vuelva a ingresarla: ");
                opcionSeleccionada = Vista.ReadLine();
            }


            switch (int.Parse(opcionSeleccionada))
            {
                case 1:
                    Cotizar();
                    break;

                case 2:
                    MostrarHistorial();
                    break;
            }
        }


        #region Cotizar
        private static void Cotizar()
        {
            Prenda prenda = null;
            Vista.Write("Ingresar codigo de la prenda: ");
            var codigoPrenda = Vista.ReadLine();
            prenda = tienda.BuscarPrenda(codigoPrenda);
            while (prenda == null)
            {
                Vista.WriteLine("La prenda no existe. :(");
                Vista.WriteLine("Ingresar codigo de la prenda: ");
                codigoPrenda = Vista.ReadLine();
                prenda = tienda.BuscarPrenda(codigoPrenda);
            }

            Vista.Write("Ingresar cantidad: ");
            int cantidad;
            var cantidadLeida = Vista.ReadLine();

            cantidad = IngresarCantidad(cantidadLeida);
            while (cantidad > prenda.Stock)
            {
                Vista.Write("Stock insuficiente, Ingresar cantidad: ");
                cantidadLeida = Vista.ReadLine();
                cantidad = IngresarCantidad(cantidadLeida);
            }

            var resultado = prenda.CalcularResultado(cantidad);
           
            var cotizacion = new Cotizacion();
            cotizacion.Prenda = prenda;
            cotizacion.Cantidad = cantidad;
            cotizacion.Resultado = Math.Round(resultado, 2);
            cotizacion.Fecha = DateTime.Now;
            cotizacion.Vendedor = vendedor;

            vendedor.Cotizaciones.Add(cotizacion);
            Vista.WriteLine($"El resultado de la cotización para una prenda de tipo {cotizacion.ResultadoCompleto()}");
            Vista.WriteLine($"Cotización guardada en el historial, presione una tecla para realizar otra operación.");

            Vista.ReadKey();
            Vista.Clear();
            MostrarMenu();
        }

        static int IngresarCantidad(string cantidadLeida)
        {
            int cantidad;
            while (!int.TryParse(cantidadLeida, out cantidad))
            {
                Vista.Write("Canidad incorrecta. Ingresar cantidad: ");
                cantidadLeida = Vista.ReadLine();
            }
            return cantidad;
        }
        #endregion


        private static void MostrarHistorial()
        {
            Vista.WriteLine($"Historial de cotizaciones");
            foreach (var cotizacion in vendedor.Cotizaciones)
            {
                Vista.WriteLine(cotizacion.ResultadoCompleto());
            }
            Vista.WriteLine($"Presione una tecla para realizar otra operación.");
            Vista.ReadKey();
            Vista.Clear();
            MostrarMenu();
        }

        private static bool ValidarOpcion(string opcion)
        {
            int opcionInt;
            if (!int.TryParse(opcion, out opcionInt))
            {
                return false;
            }
            return opcionesMenu.FirstOrDefault(x => x.Opcion == opcionInt) != null;
        }
    }
}
