public class Ex03
{
    public static void Executar()
    {
        Console.WriteLine("\nPAR OU ÍMPAR?\n");

        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("\nNúmero par.");
        }
        else
        {
            Console.WriteLine("\nNúmero Ímpar.");
        }
    }
}