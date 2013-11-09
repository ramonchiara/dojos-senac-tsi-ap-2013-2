using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Simulacao
    {
        public static int ContarAeroportos(char[,] Mapa)
        {
            int cont = 0;

            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < Mapa.GetLength(1); j++)
                {
                    if (Mapa[i, j] == 'A')
                    {
                        cont += 1;
                    }
                }
            }

            return cont;
        }

        public static char[,] Expandir(char[,] Mapa)
        {
            char[,] esperado = new char[3, 3];

            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < Mapa.GetLength(1); j++)
                {
                    if (Mapa[i, j] == ' ')
                    {
                        esperado[i, j] = ' ';
                    }
                    if (Mapa[i, j] == 'A')
                    {
                        esperado[i, j] = 'A';
                    }
                    if (Mapa[i, j] == '*')
                    {
                        esperado[i, j] = '*';
                        esperado[i, j - 1] = '*';
                        esperado[i, j + 1] = '*';
                        esperado[i - 1, j] = '*';
                        esperado[i + 1, j] = '*';
                    }
                }
            }
            return esperado;
        }
    }
}
