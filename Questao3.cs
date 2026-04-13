using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lo1_AnaliseExperimental
{
    public class Questao3
    {

        public static void RemoverPrimeiroElementoLista(List<int> listaARemover)
        {
            for (int i = 0; i < listaARemover.Count; i++)
            {
                listaARemover.RemoveAt(i);


            }
        }


        public static void RemoverPrimeiroElementoLinkedList(LinkedList<int> listaARemover)
        {
            while(listaARemover.Count > 0)
            {
                listaARemover.RemoveFirst();
            }
        }

        public static void RemoverUltimoElementoList(List<int> listaARemover)
        {
            for(int i = listaARemover.Count - 1; i >= 0; i--)
            {
                listaARemover.RemoveAt(i);
            }

        }


        public static void RemoverUltimoElementoLinkedList(LinkedList<int> listaARemover)
        {
            while( listaARemover.Count > 0)
            {
                listaARemover.RemoveLast();
            }
        }
    }
}
