using cores;
using Carros;   


Console.Write("Qual a marca? ");
string? marca = Console.ReadLine();

Console.Write("Qual o modelo? ");
string? modelo = Console.ReadLine();

Console.Write("Qual o ano? ");
int ano = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual a cor dentre as opções? \n\nBranco = 1 , Vermelho = 2, Preto = 3, Cinza = 4, Prata = 5, Azul = 6. ");
int cores = Convert.ToInt32(Console.ReadLine());


if(cores > 6)
    Console.WriteLine("\nCor não existente!");
else
{
    Cores cor = (Cores)cores;
    Carro carro1 = new Carro(marca, modelo, ano, cor);
    carro1.ExibirInfo();
}
