using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark.Model
{
    internal class Camisa : Prenda
    {

        public MangasCamisa TipoManga { get; set; }
        public CuellosCamisa TipoCuello { get; set; }


        public bool EsMangaCorta()
        {
            return this.TipoManga == MangasCamisa.Corta;
        }

        public bool EsMangaLarga()
        {
            return this.TipoManga == MangasCamisa.Larga;
        }

        public bool TieneCuelloMao()
        {
            return this.TipoCuello == CuellosCamisa.Mao;
        }


        public bool TieneCuelloComun()
        {
            return this.TipoCuello == CuellosCamisa.Comun;
        }

        public enum MangasCamisa
        {
            Corta,
            Larga
        }
        public enum CuellosCamisa
        {
            Comun,
            Mao
        }

        public override string TipoPrenda()
        {
            return "Camisa";
        }

        public string ObtenerManga()
        {
            return this.EsMangaLarga() ? "larga" : "corta";
        }

        public string ObtenerCuello()
        {
            return this.TieneCuelloMao() ? "mao" : "comun";
        }
    }
}
