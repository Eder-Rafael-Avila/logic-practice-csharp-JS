Console.WriteLine("\nESCOLHA DE EXERCÍCIOS\n");

Console.WriteLine("NÍVEL INICIANTE");
Console.WriteLine("1 - Soma de dois números.");
Console.WriteLine("2 - Média de duas notas.");
Console.WriteLine("3 - Número par ou ímpar?");
Console.WriteLine("4 - Qual número é maior?");
Console.WriteLine("5 - Contagem de 1 até n.");
Console.WriteLine("6 - Soma de 1 até n.");
Console.WriteLine("7 - Qual é o maior número da lista?");

int opcao;

do
{
    Console.Write("\nEscolha um exercício (0 pra sair): ");
    opcao = int.Parse(Console.ReadLine() ?? "0");    

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Você saiu.");
            break;

        case 1:
            Ex01.Executar();
            break;

        case 2:
            Ex02.Executar();
            break;

        case 3:
            Ex03.Executar();
            break;

        case 4:
            Ex04.Executar();
            break;

        case 5:
            Ex05.Executar();
            break;

        case 6:
            Ex06.Executar();
            break;

        case 7:
            Ex07.Executar();
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
while (opcao != 0);

