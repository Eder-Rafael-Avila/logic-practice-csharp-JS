public class Ex02
{
    public static void Executar()
    {
        Console.WriteLine("\nMÉDIA DE DUAS NOTAS\n");

        Console.Write("Insira uma nota: ");
        double n1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.Write("Insira outra nota: ");
        double n2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        double media = (n1 + n2) / 2;
        Console.WriteLine($"\nA média de {n1} e {n2} é: {Math.Round(media)}.");
    }
}