// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

Console.Clear();
Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число столбцов в массиве: ");
int columns=int.Parse(Console.ReadLine()?? "");

int[,] array=GetArray(rows, columns,0,30);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали равно {Sum(array)}");


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

int Sum(int[,] inArray)
{ 
    int box=0;
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
           if(i==j) 
           {
            box=box+inArray[i,j];
           }

        }
        
    }
    return box;
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
