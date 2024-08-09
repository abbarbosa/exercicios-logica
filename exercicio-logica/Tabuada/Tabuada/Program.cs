Console.WriteLine("Gerador de Tabuadas");
Console.WriteLine("");
Console.WriteLine("Insira um número:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabuada do {num}:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}