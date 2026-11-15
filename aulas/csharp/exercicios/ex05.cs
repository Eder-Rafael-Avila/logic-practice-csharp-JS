public class Ex05
{
    internal static void Contar(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i} ");
        }
    }
    public static void Executar()
    {
        Console.WriteLine("\nCONTAGEM DE 1 ATÉ N.\n");

        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        Contar(num);
    }
}