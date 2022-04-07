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

double sum = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum += array [j,i];
    }
    Console.WriteLine($"Седнее арифметическое {i+1} столбца равно {sum / n}");
    sum=0;
}