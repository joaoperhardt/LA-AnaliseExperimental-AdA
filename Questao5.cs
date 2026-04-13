using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lo1_AnaliseExperimental
{
    public class Questao5
    {
        public static void AcessarIndiceAleatorioList(List<int> lista)
        {
            var tamanho = lista.Count;
            Random random = new Random(123);

            int indice = random.Next(0, tamanho);

            int valor = lista[indice];
        }

        public static int AcessarIndiceAleatorioLinkedList(LinkedList<int> linkedList)
        {
            int tamanho = linkedList.Count;
            Random random = new Random(123);

            int indice = random.Next(0, tamanho);
            if (indice == 0)
            {
                return linkedList.First();
            }

            if (indice == tamanho -1)
            {
                return linkedList.Last();
            }

            int posicaoAtual = 1;
            var primeiro = linkedList.First;

            while(posicaoAtual != indice)
            {
                primeiro = primeiro.Next;
                posicaoAtual++;
            }

            return primeiro.Value;
        }
    }
}
