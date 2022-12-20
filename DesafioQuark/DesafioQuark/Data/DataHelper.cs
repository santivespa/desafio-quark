using DesafioQuark.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Data
{
    internal static class DataHelper
    {

        public static Tienda CargarTienda()
        {
            var tienda = new Tienda();
            tienda.Nombre = "Tienda Test";
            tienda.Direccion = "18 de Julio 255";


            #region Camisas manga corta
            // 100 Camisas manga corta cuello mao standard
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 1,
                TipoManga = Camisa.MangasCamisa.Corta,
                TipoCuello = Camisa.CuellosCamisa.Mao,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 10,
                Stock = 100
            });

            // 100 Camisas manga corta cuello mao premium
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 2,
                TipoManga = Camisa.MangasCamisa.Corta,
                TipoCuello = Camisa.CuellosCamisa.Mao,
                Calidad = Prenda.CalidadPrenda.Premium,
                Precio = 20,
                Stock = 100
            });

            // 150 Camisas manga corta cuello comun standard
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 3,
                TipoManga = Camisa.MangasCamisa.Corta,
                TipoCuello = Camisa.CuellosCamisa.Comun,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 30,
                Stock = 150
            });

            // 150 Camisas manga corta cuello comun premium
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 4,
                TipoManga = Camisa.MangasCamisa.Corta,
                TipoCuello = Camisa.CuellosCamisa.Comun,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 40,
                Stock = 150
            });
            #endregion

            #region Camisas manga larga

            // 75 Camisas manga larga cuello mao standard
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 5,
                TipoManga = Camisa.MangasCamisa.Larga,
                TipoCuello = Camisa.CuellosCamisa.Mao,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 50,
                Stock = 75
            });

            // 75 Camisas manga larga cuello mao premium
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 6,
                TipoManga = Camisa.MangasCamisa.Larga,
                TipoCuello = Camisa.CuellosCamisa.Mao,
                Calidad = Prenda.CalidadPrenda.Premium,
                Precio = 60,
                Stock = 75
            });

            // 175 Camisas manga larga cuello comun standard
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 7,
                TipoManga = Camisa.MangasCamisa.Larga,
                TipoCuello = Camisa.CuellosCamisa.Comun,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 70,
                Stock = 175
            });

            // 175 Camisas manga larga cuello comun premium
            tienda.Prendas.Add(new Camisa()
            {
                Codigo = 8,
                TipoManga = Camisa.MangasCamisa.Larga,
                TipoCuello = Camisa.CuellosCamisa.Comun,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 80,
                Stock = 175
            });

            #endregion

            #region Pantalones chupines
            // 750 pantalones chupines standard
            tienda.Prendas.Add(new Pantalon()
            {
                Codigo = 9,
                Tipo = Pantalon.TipoPantalon.Chupin,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 10,
                Stock = 750
            });

            // 750 pantalones chupines premium
            tienda.Prendas.Add(new Pantalon()
            {
                Codigo = 10,
                Tipo = Pantalon.TipoPantalon.Chupin,
                Calidad = Prenda.CalidadPrenda.Premium,
                Precio = 20,
                Stock = 750
            });
            #endregion

            #region Pantalones comunes
            // 250 pantalones comunes standard
            tienda.Prendas.Add(new Pantalon()
            {
                Codigo = 11,
                Tipo = Pantalon.TipoPantalon.Comun,
                Calidad = Prenda.CalidadPrenda.Standard,
                Precio = 30,
                Stock = 250
            });

            // 250 pantalones comunes premium
            tienda.Prendas.Add(new Pantalon()
            {
                Codigo = 12,
                Tipo = Pantalon.TipoPantalon.Comun,
                Calidad = Prenda.CalidadPrenda.Premium,
                Precio = 40,
                Stock = 250
            });
            #endregion

            return tienda;
        }


        public static Vendedor CargarVendedor()
        {

            var vendedor = new Vendedor();
            vendedor.Codigo = 1;
            vendedor.Nombre = "Santiago";
            vendedor.Apellido = "Vespa";

            return vendedor;
        }
    }
}
