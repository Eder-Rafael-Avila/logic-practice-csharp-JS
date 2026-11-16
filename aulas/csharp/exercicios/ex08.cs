public class Ex08
{
    internal static void ExibirLista(double[] lista)
    {
        foreach (double n in lista)
        {
            Console.Write($"{n} ");
        }
    }
    internal static void PedirNumeros(double[] lista, int qtd)
    {
        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Insira um número: ");
            lista[i] = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("");
        }
    }
    internal static int VerificarOcorrencias(double num, double[] lista)
    {
        int qtdOcorrencias = 0;

        foreach (double pos in lista)
        {
            if (pos == num)
            {
                qtdOcorrencias++;
            }
        }

        return qtdOcorrencias;
    }
    public static void Executar()
    {
        Console.WriteLine("\nCONTAR OCORRÊNCIAS\n");

        Console.Write("Quantos números terá a lista: ");
        int qtdNumeros = int.Parse(Console.ReadLine() ?? "0");

        double[] lista = new double[qtdNumeros];
        PedirNumeros(lista, qtdNumeros);

        Console.Write("Qual número você quer verificar? => ");
        double valor = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("");

        ExibirLista(lista);
        Console.WriteLine($"\nNa lista acima o número {valor} aparece {VerificarOcorrencias(valor, lista)} vezes.");
    }
}