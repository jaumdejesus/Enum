using System;
using System.Security.Cryptography.X509Certificates;
using cores;

public class Carro
{
	public string? Modelo { get; set; }
	public string? Marca { get; set; }
	public int Ano { get; set; }
	public int Cor {  get; set; }

	public Carro(string? modelo, string? marca, int ano, int cor)
	{
		Modelo = modelo;
		Marca = marca;
		Ano = ano;
		Cor = cor;

		Console.WriteLine();
	}

	public void ExibirInfo(string? modelo, string? marca, int ano, int cor)
	{
		Console.WriteLine($"Informações do seu carro: Modelo{modelo}, Marca:{marca}, Ano: {ano}, Cor: {cor}");
	}
}
