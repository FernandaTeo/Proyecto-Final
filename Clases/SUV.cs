using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class SUV : VehiculoBase
    {
        //aca coloque las nuevas propiedades y metodos
        public string lucesled{ get; set; }
        public string parabrisas{ get; set; }
        public string polarizado { get; set; }
        public void balsas()
        {
            Console.WriteLine("Las balsas de su auto se han activado, puede entrar al agua sin ningun problema");
        }
    }
}
