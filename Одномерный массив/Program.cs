namespace Одномерный_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int width = 10;
            List<int> array = new List<int>(width);
            int sum = 0;

            for (int i = 0; i < width; i++)
            {                
                array[i] = random.Next(-100, 100);
            }
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine($"{array[i]}\t");
                sum += array[i];
            }
            if (sum < 0)
            {
                Console.WriteLine($"Недостающее число до нуля: {sum * (-1)}");
                array.Add(sum);
            }
            Console.WriteLine("Fixed array: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"{array[i]}\t");
               
            }
        }
    }
}