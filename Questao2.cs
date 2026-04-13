using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lo1_AnaliseExperimental
{
    public class Questao2
    {

        public static void inserirListPosicaoAleatoria(int tamanho)
        {
            List<int> lista = new List<int>(new int[tamanho]); // inicializa com zeros
            int posicoesPreenchidas = 0;
            Random rdm = new Random();

            while (posicoesPreenchidas < tamanho)
            {
                int posicaoAInserir = rdm.Next(tamanho);

                if (lista[posicaoAInserir] == 0)
                {
                    lista[posicaoAInserir] = rdm.Next(1, int.MaxValue); // evita zero
                    posicoesPreenchidas++;
                }
            }
        }


        public static void inserirLinkedListPosicaoAleatoria(int tamanho)
        {
            LinkedList<int> lista = new LinkedList<int>(
                Enumerable.Repeat(-1, tamanho)
            );

            Random rdm = new Random();
            int preenchidos = 0;

            while (preenchidos < tamanho)
            {
                int pos = rdm.Next(tamanho);

                var node = lista.First;
                for (int i = 0; i < pos; i++)
                    node = node.Next;

                if (node.Value == -1)
                {
                    node.Value = rdm.Next();
                    preenchidos++;
                }
            }
        }
    }
}
