namespace Задание_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int pozitive = 0, negative = 0;

            do 
            {
                Console.WriteLine("enter number");
                number = int.Parse(Console.ReadLine());
                if (number == -65432)
                {
                    break;
                }
                else if (number > 0)
                {
                    pozitive++;
                }
                else if (number < 0)
                {
                    negative++;
                }
            } while (number != -65432);
            float sum = negative + pozitive;
            Console.WriteLine($"negative is {negative / sum * 100 } %");
            Console.WriteLine($"negative is {pozitive / sum * 100 } %");
        }
    }
}