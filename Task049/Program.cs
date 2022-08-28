// Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
Console.Clear();
Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число столбцов в массиве: ");
int columns=int.Parse(Console.ReadLine()?? "");
int[,] array=GetArray(rows, columns,0,30);
PrintArray(array);
array=CopyArray(array);
Console.WriteLine("Измененный массив");
PrintArray(array);

int[,] GetArray(int m, int n,int minValue,int maxValue)
{
    int[,] result= new int [m,n];

    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}

int[,] CopyArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
           if(i%2!=0 && j%2!=0) //для строк и столбцов как в матиматике
           {
            inArray[i,j]=inArray[i,j]*inArray[i,j];
           }

        }
        
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
