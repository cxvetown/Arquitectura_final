using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Devolucion_valor
    {
        public int Generar_total()
        {
            int valor = 0;
            Random ran = new Random();
            valor = ran.Next(0, 5000);
            return valor;
        }
    }
}
