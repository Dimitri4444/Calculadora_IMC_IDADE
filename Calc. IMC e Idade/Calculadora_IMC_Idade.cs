using System;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        double altura, peso, imc;

        do
        {
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso (em kg): ");
            peso = double.Parse(Console.ReadLine());

            // Cálculo do IMC
            imc = peso / (altura * altura);

            // Determinando a categoria de IMC
            string categoriaIMC;
            if (imc < 18.5)
                categoriaIMC = "Abaixo do peso";
            else if (imc < 24.9)
                categoriaIMC = "Peso normal";
            else if (imc < 29.9)
                categoriaIMC = "Sobrepeso";
            else if (imc < 34.9)
                categoriaIMC = "Obesidade Grau I";
            else if (imc < 39.9)
                categoriaIMC = "Obesidade Grau II";
            else
                categoriaIMC = "Obesidade Grau III";

            // Determinando a faixa etária
            string faixaEtaria;
            if (idade < 18)
                faixaEtaria = "Menor de idade";
            else if (idade < 30)
                faixaEtaria = "Jovem adulto";
            else if (idade < 60)
                faixaEtaria = "Adulto";
            else
                faixaEtaria = "Idoso";

            // Exibindo o relatório
            Console.WriteLine($"Relatório de {nome}:");
            Console.WriteLine($"IMC: {imc:F2} - Categoria de IMC: {categoriaIMC}");
            Console.WriteLine($"Idade: {idade} anos - Faixa Etária: {faixaEtaria}");

            Console.Write("Deseja calcular para outra pessoa? (s/n): ");
        } while (Console.ReadLine().ToLower() == "s");
    }
}
