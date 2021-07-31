using System;
using System.Collections.Generic;
using System.Drawing;//agregar a la libreria using System.Drawing
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePoly x = new ClasePoly();
            x.Poly(42);
            x.Poly("abcd");
            x.Poly(12.345678901234m);
            x.Poly(new Point(23, 45));
            Console.ReadKey();
            //se obtendra su valor en la consola de la aplicación//
           // através de comportamiento polimórfico.No importa el tipo de dato enviado//

        }
    }
}
