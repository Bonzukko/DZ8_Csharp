Console.Clear();
Random random = new Random();
int[,] matrix = new int[random.Next(2, 6), random.Next(2, 6)];
int minSum = int.MaxValue;
int result = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(0, 100);
        Console.Write(matrix[i, j] + " ");
        sum += matrix[i, j];
    }
    Console.WriteLine();
    if (sum < minSum)
    {
        minSum = sum;
        result = i + 1;
    }
}
Console.WriteLine($"номер строки с наименьшей суммой элементов: {result}");