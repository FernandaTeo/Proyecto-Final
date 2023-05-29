using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class CuatroPorCuatro : VehiculoBase
    {
        //aca coloque las nuevas propiedades y metodo 
        public string defensa { get; set; }
        public string  respiradero { get; set; }
        public string llantaderepuesto { get; set; }
        public void  traccion()
        {
            Console.WriteLine("Su carro ahora tiene mas potencia");
        }
    }
}
