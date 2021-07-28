using System;
using System.Globalization;

namespace _1exercicio {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine($"{produto1}, cujo preço e $ {preco1}.");
            Console.WriteLine($"{produto2}, cuo preço é $ {preco2}.");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}.");

            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondando(três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3" ,CultureInfo.InvariantCulture)} ");
        }
    }
}
