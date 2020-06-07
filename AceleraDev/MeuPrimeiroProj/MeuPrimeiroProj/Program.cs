using System;

namespace MeuPrimeiroProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string sobrenome;

            string nome = "Rafael"; 
            bool EProgramador = true;
            int idade = 20;
            sobrenome = "Moura";

            // Operadores aritmeticos

            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 5;

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtracao: {subtracao}");
            Console.WriteLine($"Multiplicacao: {multiplicacao}");
            Console.WriteLine($"Divisao: {divisao}");
            Console.WriteLine($"Resto: {mod}");

            // Operadores lógicos

            var Everdadeiro = true && true;
            var Efalso2 = false && false;
            var Efalso1 = true && false;

            var OuVerdadeiro1 = true || true;
            var OuVerdadeiro2 = false || true;
            var OuVerdadeiro3 = true || false;
            var OuFalso = false || false;

            Console.WriteLine(Everdadeiro);
            Console.WriteLine(Efalso2);
            Console.WriteLine(Efalso1);

            Console.WriteLine(OuVerdadeiro1);
            Console.WriteLine(OuVerdadeiro2);
            Console.WriteLine(OuVerdadeiro3);
            Console.WriteLine(OuFalso);

            var falsoNegado = !false;
            var verdadeiroNegado = !true;

            Console.WriteLine(falsoNegado);
            Console.WriteLine(verdadeiroNegado);

            // Conversão implícita

            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5f;
            double varDouble = varFloat;

            char varChar = 'T';
            int varInt1 = varChar;

            string meuTexto = $"Conversão implicita de variavel inteira {varInt} e variavel float {varFloat}";

            Console.WriteLine(meuTexto);
        }
    }
}
