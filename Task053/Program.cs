// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число столбцов в массиве: ");
int columns=int.Parse(Console.ReadLine()?? "");

int[,] array=GetArray(rows, columns,0,100);
PrintArray(array);

GangeFirstLastRows(array);
Console.WriteLine();
PrintArray(array);




/////////////////////////////////////////////////
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

void GangeFirstLastRows (int[,] inArray)
{ 
    int box;
    for(int j=0; j<inArray.GetLength(1); j++)
    {
        box=inArray[0,j];
        inArray[0,j]=inArray[inArray.GetUpperBound(0),j];
        inArray[inArray.GetUpperBound(0),j]=box;      
    }
}

    


