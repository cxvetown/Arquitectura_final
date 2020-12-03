using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Arrendar_codigo
    {
        public int Generar_codigo()
        {
            int valor = 0;
            Random ran = new Random();
            valor=ran.Next(0, 999999);
            return valor;
        }
    }
}
