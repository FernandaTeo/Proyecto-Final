using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class PickUp : VehiculoBase
    {
        //aca coloque las nuevas propiedades y metodos
        public int numpuertas { get; set; }

        public string covertible { get; set; }

        public string tipcaja { get; set; }
        public void sistemadeseguridad()
        {
            Console.WriteLine("Se ha activado el sistema de seguridad");
        }
    }
}
