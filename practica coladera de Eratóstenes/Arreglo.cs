using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_coladera_de_Eratóstenes
{
    abstract class Arreglo
    {
        static private int[] _vector;
        /*
        public Arreglo(int numeroElementos)
        {
            _vector = new int[numeroElementos];
            for(int i=1; i<numeroElementos; i++)
            {
                _vector[i] = 1;
            }
        }
        */

        static public string coladera(int numeroElementos)
        {
            _vector = new int[numeroElementos];

            for (int i = 1; i < numeroElementos; i++)
            {_vector[i] = 1;}

            for (int i=2; i < numeroElementos; i++)
            {
                for(int h=3; h < numeroElementos; h++)
                {
                    if(h % i == 0 && h != i)
                        _vector[h] = 0;
                }
            }

            string numerosPrimos = "";

            for (int j=1; j < numeroElementos; j++)
            {
                if (_vector[j] == 1)
                    numerosPrimos += j + ", ";
            }

            return numerosPrimos;
        }
    }
}
