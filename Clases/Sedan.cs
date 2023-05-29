using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class Sedan : VehiculoBase
    {
        //aca coloque las nuevas propiedades y metodos
        public int sillones { get; set; }
        public string ventanas { get; set; }
        public string aireacondicionado { get; set; }
        public void radio()
        {
            Console.WriteLine("Su carro ha encendido la radio");
        }
    }
}
