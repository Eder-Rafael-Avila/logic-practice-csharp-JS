public class Ex06
{
    internal static int SomarAteN(int n)
    {
        int soma = 0;

        for (int i = 1; i <= n; i++)
        {
            soma += i;
        }

        return soma;
    }
    public static void Executar()
    {
        Console.WriteLine("\nSOMA DE 1 ATÉ N\n");

        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine() ?? "0");

        int result = SomarAteN(num);
        Console.WriteLine($"\nA soma de 1 até {num} é: {result}.");
    }
}