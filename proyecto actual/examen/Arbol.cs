using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class Arbol
    {
        public int DecidirCamino(int numero)
        {
            if (numero <= 2)
            {
                if (numero == 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }
    }
}
