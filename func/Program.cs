using func;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        int x = int.Parse(Console.ReadLine());

        int[,] matrix = new int[x, x];

        Solution solution = new(x, matrix);
        Console.WriteLine(solution.GetSolution());
    }
}