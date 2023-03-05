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
                    Console.WriteLine("A soma é igual a " + (number1 + number2).ToString("F2"));
                    Console.ReadKey();    
                    break;
                case 2:
                    Console.WriteLine("A subtração é igual a " + (number1 - number2).ToString("F2"));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("A multiplicação é igual a " + (number1 * number2).ToString("F2"));
                    Console.ReadKey();
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        Console.WriteLine("Não é possível realizar a divisão por ZERO!");
                    }
                    else
                    {
                        Console.WriteLine("A divisão é igual a " + (number1 / number2).ToString("F2"));
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Ok, até mais!");
                    break;
                default:
                    Console.WriteLine("Valor informado inválido. Por favor, aperte a tecla ENTER e digite um valor válido");
                    Console.ReadKey();
                    break;
            }
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