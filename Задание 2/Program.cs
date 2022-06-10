namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int width, length;
            Console.WriteLine("enter width");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("enter length");
            length = int.Parse(Console.ReadLine());
            int[,] matriwx = new int[width, length];

            List<List<int>> matrix = Enumerable.Range(1, width).Select(i => Enumerable.Range(1, length).ToList()).ToList();

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    matrix[row][col] = random.Next(10);
                }
            }
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write($"{matrix[row][col]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("enter length which will crop");
            int cropLength = int.Parse(Console.ReadLine());

            matrix = Enumerable.Range(1, width).Select(i => Enumerable.Range(1, length + 1).ToList()).ToList();


            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write($"{matrix[row][col]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}