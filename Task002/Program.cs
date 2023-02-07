// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
void OrderLine(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if(matrix[i,k] < matrix[i, k+1])
                {
                    int temp = matrix[i, k+1];
                    matrix[i,k+1] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
OrderLine(matrix);
Print(matrix);