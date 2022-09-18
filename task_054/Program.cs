Console.Clear();
Console.WriteLine("Например, задан массив: ");
Random random = new Random();
int[,] matrix = new int[random.Next(2, 11), random.Next(2, 11)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(-99, 100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("В итоге получается вот такой массив: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            int max = matrix[i, j];
            if (matrix[i, k] > max)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}