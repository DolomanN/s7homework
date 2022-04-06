Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i,j] = new Random().Next(1,10);
         Console.Write($"{array[i,j]},");;
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i % 2 == 1 && j % 2 ==1)
        {
            Console.Write ($"{array[i,j] * array [i,j]},");
        }
        else
        {
           Console.Write ($"{array[i,j]},"); 
        }
    }
    Console.WriteLine();
}