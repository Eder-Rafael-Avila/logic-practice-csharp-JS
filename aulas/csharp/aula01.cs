
Console.Write("Digite um número: ");

string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int idade))
{
    Console.WriteLine($"Seu número é: {idade}");
}
else
{
    Console.WriteLine("Isto não é um número!");
}






// Console.Write("Insira um número de 0 a 1: ");
// int num = int.Parse(Console.ReadLine());
// bool valor = Convert.ToBoolean(num);

// Console.WriteLine($"O valor de {num} é {valor}");





// float menorDecimal = 3.12222f;
// double comumDecimal = 3.1111111111;
// decimal maiorDecimal = 3.111111111111111111m;

// Console.WriteLine($"Menor: {menorDecimal}, médio: {comumDecimal}, maior: {maiorDecimal}!");





// Console.Write("Seu nome é: ");
// string nome = Console.ReadLine();

// Console.Write("Sua idade é: ");
// int idade = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Seu nome é {nome} e sua idade é {idade}");
// Console.WriteLine("Eu gosto de \t\"Comerrr\"");
// Console.WriteLine("Para pular linha: \\n");

// Console.WriteLine("Olá, Mundo!");
// Console.WriteLine("Salveeee");

// Console.Write("Sem ");
// Console.Write("quebra\n");
// Console.Write("Próxima linha com barra invertida + n\n");

// Console.Write("próxima linha");

// string nome = "Eder";
// int idade = 17;

// Console.WriteLine($"{nome} tem {idade} anos e gosta de ping pong.");