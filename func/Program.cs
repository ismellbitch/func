// вариант 20
int[,] matrix = new int[5, 5];
Random r = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = r.Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
int sum = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i != j) sum += matrix[i, j];
    }
}
Console.WriteLine(sum);