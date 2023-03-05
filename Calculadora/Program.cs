using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double number1;
        double number2;
        int option = 0;

        void Menu()
        {
            Console.Clear();
            Console.WriteLine("[1] - Somar");
            Console.WriteLine("[2] - Subtrair");
            Console.WriteLine("[3] - Multiplicar");
            Console.WriteLine("[4] - Dividir");
            Console.WriteLine("[5] - Sair");
            Console.Write("Escolha uma operação matemática: ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Sub();
                    break;
                case 3:
                    Mult();
                    break;
                case 4:
                    Div();
                    break;
                case 5:
                    Bye();
                    break;
                default:
                    Error();
                    break;
            }
        }

        void Sum()
        {
            Console.WriteLine("A soma é igual a " + (number1 + number2).ToString("F2"));
            Console.ReadKey();
        }

        void Sub()
        {
            Console.WriteLine("A subtração é igual a " + (number1 - number2).ToString("F2"));
            Console.ReadKey();
        }

        void Mult()
        {
            Console.WriteLine("A multiplicação é igual a " + (number1 * number2).ToString("F2"));
            Console.ReadKey();
        }

        void Div()
        {
            if (number2 == 0)
            {
                Console.WriteLine("Não é possível realizar a divisão por ZERO!");
            }
            else
            {
                Console.WriteLine("A divisão é igual a " + (number1 / number2).ToString("F2"));
            }
            Console.ReadKey();
        }

        void Bye()
        {
            Console.WriteLine("Ok, até mais!");
        }

        void Error()
        {
            Console.WriteLine("Valor informado inválido. Por favor, aperte a tecla ENTER e digite um valor válido");
            Console.ReadKey();
        }

        Console.Write("Digite o 1° número: ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o 2° número: ");
        number2 = double.Parse(Console.ReadLine());
        Console.WriteLine();

        while (option != 5)
        {
            Menu();
        }
    }
}