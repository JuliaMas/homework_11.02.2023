// Написать программу, которая обменивает элементы первой строки и последней строки
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

int temp = 0;

for(int i = 0; i < matrix.GetLength(0); i++)
{
	for(int j = 0; j < matrix.GetLength(1); j++)
	{
		temp = matrix[0,j];
		matrix[0,j] = matrix[n-1, j];
		matrix[n-1,j] = temp;
	}
}
Console.WriteLine();
Print(matrix);