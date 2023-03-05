internal class Program
{
    private static void Main(string[] args)
    {
        double number1;
        double number2;

        Console.Write("Digite o 1° número: ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o 2° número: ");
        number2 = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("A soma é igual a " + (number1 + number2).ToString("F2"));
        Console.WriteLine("A subtração é igual a " + (number1 - number2).ToString("F2"));
        Console.WriteLine("A multiplicação é igual a " + (number1 * number2).ToString("F2"));
        if (number2 == 0)
        {
            Console.WriteLine("Não é possível realizar a divisão por ZERO!");
        }
        else
        {
            Console.WriteLine("A divisão é igual a " + (number1 / number2).ToString("F2"));
        }
    }
}