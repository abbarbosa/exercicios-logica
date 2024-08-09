Console.WriteLine("Insira a nota: ");
// Lê a entrada do usuário como string, converte para double e armazena na variável 'nota'
double nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado!");
}
else if (nota >= 5)
{
    Console.WriteLine("Recuperação!");
}
else 
{
    Console.WriteLine("Reprovado!!!");
}