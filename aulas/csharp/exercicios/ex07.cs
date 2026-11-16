public class Ex07
{
    internal static void Exibir(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write($"{num} ");
        }
    }

    internal static void PedirNumeros(int qtd, int[] array)
    {
        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Insira um número: ");
            array[i] = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine("");
        }
    }
    public static void Executar()
    {
        Console.WriteLine("\nMAIOR NÚMERO DA LISTA\n");

        Console.Write("Quantos números você deseja inserir? ");
        int qtdNumeros = int.Parse(Console.ReadLine() ?? "1");

        int[] lista = new int[qtdNumeros];

        PedirNumeros(qtdNumeros, lista);

        Exibir(lista);
        Console.WriteLine($"\nO maior número da lista é: {lista.Max()}");
    }
}