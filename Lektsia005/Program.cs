// Вывод и заполнение двумерного массива
Console.Clear();

int[,] matrix = new int[5,10];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matr)
{ 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
             matr[i, j] = new Random().Next(0, 100);
        }
    }
}