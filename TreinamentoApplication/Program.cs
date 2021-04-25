using Backend;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreinamentoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindos ao Treinamento .NET");

            //criando uma lista de objetos que implementam a interface IVeiculo
            var listCarro = new List<IVeiculo>();

            //instanciando um carro invocando o construto defaul
            Carro veiculo = new Carro();

            //populando a lista...
            listCarro.Add(new Carro("verde", "fusca"));
            listCarro.Add(new Carro("azul", "fusca"));
            listCarro.Add(new Carro("azul", "vectra"));
            listCarro.Add(new Carro("branco", "gol"));
            //instanciando um objeto carro utilizando um inicializado de objetos
            //ao invés de invocar um construtor
            listCarro.Add(new Carro
            {
                Cor = "branco",
                Nome = "uno"
            });

            //consulta LINQ no formato method query
            //Obs.: Atenção para a transformação que está sendo feita através do método Select()
            var listOrdenada = listCarro
                                .OrderBy(x => x.Cor)
                                .Select(carr => 
                                new Moto
                                {
                                   Cor = carr.Cor,
                                   Nome = carr.Nome
                                });

            //consulta LINQ no formato query based
            var listaOrdenada2 = from list in listCarro
                                 orderby list.Cor
                                 select new Moto
                                 {
                                     Cor = list.Cor,
                                     Nome = list.Nome
                                 };

            //iterando sob a lista e imprimindo no console os valores das propriedades dos objetos.
            foreach (var v in listaOrdenada2)
            {
                Console.WriteLine($"{v.Tipo}: {v.Cor}");
                Console.WriteLine($"Nome: {v.Nome}");
            }

            Console.ReadKey();




        }
    }
}
