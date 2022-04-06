Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] array = new double [n,m];
//Random r = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i,j] = new Random().NextDouble();
         Console.Write($"{array[i,j]}");
         Console.WriteLine();
    }
    Console.WriteLine();
}
