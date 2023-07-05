
interface ICalculator { void Sum(int a, int b); }
public class Calculator : ICalculator
{
    void ICalculator.Sum(int a, int b) { Console.WriteLine("Ваш результат: " + (a + b) + "\n"); }
}

class Program
{

    static void Main(string[] args)
    {
        ICalculator calculator = new Calculator();
        while (true)
        {
            try
            {
                Console.WriteLine("Введите 2 числа, которые вы хотите сложить: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                calculator.Sum(a, b);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

    }


}


