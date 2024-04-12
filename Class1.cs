
using System;
using cores;

namespace Carros
{
    public class Carro
    {
        public string? Marca {  get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor {  get; set; }

        public Carro(string? marca, string? modelo, int ano, Cores cor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor.ToString();
        }

        public void ExibirInfo()
        {            
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Cor: {Cor}");
        }
    }
}
