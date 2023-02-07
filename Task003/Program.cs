// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void Fill(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i,j] = new Random().Next(1,10);
		}
	}
}
void Print(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i,j]} ");
		}
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк n: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов m: ");
int m = int.Parse(Console.ReadLine() ?? "");

int[,] matrix = new int[n,m];
Fill(matrix);
Print(matrix);
Console.WriteLine();

int minSum = 9*m;
int indexLine = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i,j];
        
    }
    if(sum < minSum)
    {
        minSum = sum;
        indexLine = i;
    }
}
Console.WriteLine("Индекс строки с наименьшей суммой элементов " + indexLine);
