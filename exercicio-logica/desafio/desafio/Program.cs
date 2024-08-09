// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//crie um programa que gere um número entre 1 e 10. O usuário deve tentar adivinhar esse número. 
//O programa deve continuar pedindo um palpite até que o usuário acerte o número.
//ao final mostre quantas tentativas foram necessárias.

Random random = new Random();

int aleatorio = random.Next(1, 11);
bool returnTry;


int chute;
int tentativas= 0; 

do
{
    Console.WriteLine("tente adivinhar o número!");
    returnTry = int.TryParse(Console.ReadLine(), out chute);
    if (returnTry){
        Console.WriteLine("Número errado, tenho outra vez!");
    }
    tentativas ++;
}while(chute!= aleatorio);

Console.WriteLine($"o numero de tentativas foi{tentativas}");
