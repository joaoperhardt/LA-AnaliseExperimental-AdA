using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lo1_AnaliseExperimental
{
    public class Questao2
    {
        public static void inserirList(int tamanho)
        {
            List<int> lista = new List<int>(tamanho);
            Random random = new Random(123);
            for (int i = 0; i < tamanho; i++)
            {
                lista.Add(random.Next());
            }
        }
    }
}
