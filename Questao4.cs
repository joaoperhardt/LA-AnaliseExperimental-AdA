using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lo1_AnaliseExperimental
{
    public class Questao4
    {

        public static void RemoverListPosicaoAleatoria(List<int> listaARemover)
        {
            Random rd = new Random();
            while(listaARemover.Count > 0)
            {
                int posicaoARemover = rd.Next(listaARemover.Count - 1);
                
                    listaARemover.RemoveAt(posicaoARemover);
                
            }
        }


        public static void RemoverLinkedListPosicaoAleatoria(LinkedList<int> lista)
        {
            Random rd = new Random();

            while (lista.Count > 0)
            {
                int index = rd.Next(lista.Count);
                var node = lista.First;

                for (int i = 0; i < index; i++)
                    node = node.Next;

                lista.Remove(node);
            }
        }
    }
}
