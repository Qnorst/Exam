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
            int[,] matriwx = new int[width,length];

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
            Console.WriteLine("enter width which will crop");
            int cropWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("enter length which will crop");
            int cropLength = int.Parse(Console.ReadLine());
            int srednee = 0, kolvo = 0;

/*            Console.WriteLine("Разделенная матрица: ");
            for (int row = 0; row < width; row++)
            {
                if (row == cropWidth - 1)
                {
                    Console.WriteLine();
                }
                for (int col = 0; col < length; col++)
                {
                    if (col == cropLength - 1)
                    {
                        Console.Write("\t");
                    }
                    Console.Write($"{matrix[row][col]}\t");
                }
                Console.WriteLine();
            }*/

            Console.WriteLine("Левая верхняя часть :");
            for (int row = 0; row < cropWidth; row++)
            {
                for (int col = 0; col < cropLength; col++)
                {
                    Console.Write($"{matrix[row][col]}\t");
                    srednee += matrix[row][col];
                    kolvo++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Среднее арифметическое этой части: {srednee / kolvo}");
            srednee = 0;
            kolvo = 0; 
            Console.WriteLine("Правая верхняя часть: ");
            for (int row = cropWidth - 1; row < width; row++)
            {
                for (int col = 0; col < cropLength; col++)
                {
                    Console.Write($"{matrix[row][col]}\t");
                    srednee += matrix[row][col];
                    kolvo++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Среднее арифметическое этой части: {srednee / kolvo}");
            srednee = 0;
            kolvo = 0;
            Console.WriteLine("Левая нижняя часть: ");
            for (int row = 0; row < cropWidth; row++)
            {
                for (int col = cropLength - 1; col < length; col++)
                {
                    Console.Write($"{matrix[row][col]}\t");
                    srednee += matrix[row][col];
                    kolvo++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Среднее арифметическое этой части: {srednee / kolvo}");
            srednee = 0;
            kolvo = 0;
            Console.WriteLine("Правая нижняя часть: ");
            for (int row = cropWidth - 1; row < width; row++)
            {
                for (int col = cropLength - 1; col < length; col++)
                {
                    Console.Write($"{matrix[row][col]}\t");
                    srednee += matrix[row][col];
                    kolvo++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Среднее арифметическое этой части: {srednee / kolvo}");
            srednee = 0;
            kolvo = 0;

        }
    }
}