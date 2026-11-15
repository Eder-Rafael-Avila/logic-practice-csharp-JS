public class Ex04
{
    public static void Executar()
    {
        Console.WriteLine("\nMAIOR NÚMERO?\n");

        Console.Write("Insira um número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira outro número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine($"\n{n1} é maior que {n2}.");
        }
        else if (n1 < n2)
        {
            Console.WriteLine($"\n{n2} é maior que {n1}.");
        }
        else
        {
            Console.WriteLine($"\n{n1} e {n2} são iguais.");
        }
    }
}