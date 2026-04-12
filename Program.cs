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

            for (int i = 0; i < tamanhos.Length; i++)
            {
                totalList = 0L;
                for (int j = 0; j < 10; j++) 
                { 
                    var tempoList = medirTempo(() => inserirList(tamanhos[i]));
                    totalList += tempoList;
                }
                Console.WriteLine($"Tamanho: {tamanhos[i]} - Tempo médio List: {totalList / 10} nanosegundos");
            }

            // Questão 1:
            //Console.WriteLine($"Tempo médio List: {totalList / 20} ms");
            //Console.WriteLine($"Tempo médio LinkedList: {totalLinkedList / 20} ms");
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
