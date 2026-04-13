using System.Runtime;

namespace Lo1_AnaliseExperimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tamanhos = new int[] { 10, 1000, 100000 };

            var totalList = 0L;
            // Questão 1:
            // var totalLinkedList = 0L;

            inserirList(0);
            // Questão 1:
            // inserirLinkedList(0);


            //for (int i = 0; i < 20; i++)
            //{
            //    var tempoList = medirTempo(() => inserirList(9999999));
            //    var tempoLinkedList = medirTempo(() => inserirLinkedList(9999999));
            //    totalList += tempoList;
            //    totalLinkedList += tempoLinkedList;
            //    // Console.WriteLine($"Tamanho: {tamanhos[i]} - List: {tempoList} ms, LinkedList: {tempoLinkedList} ms");
            //}

            /*for (int i = 0; i < tamanhos.Length; i++)
            {
                totalList = 0L;
                for (int j = 0; j < 10; j++)
                {
                    var tempoList = medirTempo(() => inserirList(tamanhos[i]));
                    totalList += tempoList;
                }
                Console.WriteLine($"Tamanho: {tamanhos[i]} - Tempo médio List: {totalList / 10} nanosegundos");
            }*/

            // Questão 1:
            //Console.WriteLine($"Tempo médio List: {totalList / 20} ms");
            //Console.WriteLine($"Tempo médio LinkedList: {totalLinkedList / 20} ms");


            // Questão 2
            Console.WriteLine("-------- Questão 2 -------------");
            long tempoList = 0L;
            long tempoLinkedList = 0L;
            for(int i = 0; i < 20; i++)
            {
                tempoList += medirTempo(() => Questao2.inserirListPosicaoAleatoria(999));
                tempoLinkedList += medirTempo(() => Questao2.inserirLinkedListPosicaoAleatoria(999));
            }
            Console.WriteLine($"Tempo médido List: {tempoList/20} ms");
            Console.WriteLine($"Tempo médido LinkedList: {tempoLinkedList/20} ms");


            // Questão 3
            Console.WriteLine("-------- Questão 3 -----------");
            long removerTempoLista = 0L;
            long removerTempoLinkedList = 0L;
            for (int i = 0; i < 20; i++)
            {
                List<int> listaQuestao3 = new List<int>(Enumerable.Range(0, tamanhos[1]).Select(e => e));
                removerTempoLista += medirTempo(() => Questao3.RemoverPrimeiroElementoLista(listaQuestao3));

                LinkedList<int> linkedListQuestao3 = new LinkedList<int>(Enumerable.Range(0, tamanhos[1]).Select(e => e));
                removerTempoLinkedList += medirTempo(() => Questao3.RemoverPrimeiroElementoLinkedList(linkedListQuestao3));
            }
            Console.WriteLine($"Tempo Médido List: {removerTempoLista / 20} ms");
            Console.WriteLine($"Tempo Médido LinkedList: {removerTempoLinkedList / 20} ms");


             removerTempoLista = 0L;
             removerTempoLinkedList = 0L;
            for (int i = 0; i < 20; i++)
            {
                List<int> listaQuestao3 = new List<int>(Enumerable.Range(0, tamanhos[1]).Select(e => e));
                removerTempoLista += medirTempo(() => Questao3.RemoverUltimoElementoList(listaQuestao3));

                LinkedList<int> linkedListQuestao3 = new LinkedList<int>(Enumerable.Range(0, tamanhos[1]).Select(e => e));
                removerTempoLinkedList += medirTempo(() => Questao3.RemoverUltimoElementoLinkedList(linkedListQuestao3));
            }
            Console.WriteLine($"Tempo Médido Remover Último elemento List: {removerTempoLista /20} ms");
            Console.WriteLine($"Tempo Médido Remover último elemento LinkedList: {removerTempoLinkedList / 20} ms");


            //Questão 4
            removerTempoLinkedList = 0;
            removerTempoLista = 0;
            Console.WriteLine("--------- Questão 4 ----");
            for (int i = 0; i < 20; i++)
            {
                removerTempoLista      += medirTempo(() => Questa4.RemoverListPosicaoAleatoria(new List<int>(Enumerable.Range(1, 9999).Select((e) => e).ToArray())));
                removerTempoLinkedList += medirTempo(() => Questa4.RemoverLinkedListPosicaoAleatoria(new LinkedList<int>(Enumerable.Range(1, 9999).Select((e) => e).ToArray()))); 
            }

            Console.WriteLine($"Tempo Médio Remover elemento aletório List: {removerTempoLista / 20} ms");
            Console.WriteLine($"Tempo Médido Remover elemento aleaatório LinkedList: {removerTempoLinkedList /20} ms");

            // Questão 5
            Console.WriteLine("-------------- Questão 5 ----------");
            tempoLinkedList = 0L;
            tempoList = 0L;
            List<int> lista = new List<int>(Enumerable.Range(1,10000).Select((e) => e).ToArray());
            LinkedList<int> lst = new LinkedList<int>(Enumerable.Range(1, 10000).Select((e) => e).ToArray());
            for(int i = 0; i  < 20; i++)
            {
                for(int j = 0; j< 10000; j++)
                {
                    tempoList += medirTempo(() => Questao5.AcessarIndiceAleatorioList(lista));
                    tempoLinkedList += medirTempo(() => Questao5.AcessarIndiceAleatorioLinkedList(lst));
                }
            }

            Console.WriteLine($"Tempo Médido Acesso Index aleatório List: {tempoList / 20} ms");
            Console.WriteLine($"Tempo Médido Acesso Index aleatório LinkedList: {tempoLinkedList / 20} ms");

        }
              

        

        static long medirTempo(Action action)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            action();

            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        static void inserirList(int tamanho)
        {
            List<int> lista = new List<int>(tamanho);
            Random random = new Random(123);
            for (int i = 0; i < tamanho; i++)
            {
                lista.Add(random.Next());
            }
        }

        static void inserirLinkedList(int tamanho)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Random random = new Random(123);
            for (int i = 0; i < tamanho; i++)
            {
                linkedList.AddLast(random.Next());
            }
        }



    }
}
