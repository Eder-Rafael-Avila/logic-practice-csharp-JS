
// public - Pode ser acessada em outros arquivos.
public class Ex01
{
    // public - Método que pode ser acessado fora da classe.
    // static - Método que não necessita de objeto para ser acessado.
    // void - Não retorna valor.
    public static void Executar()
    {
        Console.WriteLine("\nSOMA DE DOIS NÚMEROS\n");

        Console.Write("Digite um número para somar: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número para somar: ");
        int num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;
        Console.WriteLine($"\nA soma de {num1} + {num2} é igual a: {soma}.");
    }
}