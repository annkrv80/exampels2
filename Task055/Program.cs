//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число столбцов в массиве: ");
int columns=int.Parse(Console.ReadLine()?? "");

if(rows==columns)
{
int[,] array=GetArray(rows, columns,0,100);
PrintArray(array);

GangeRowsColums(array);
Console.WriteLine();
PrintArray(array);
}
else
{
    Console.WriteLine("Ошибка ввода данных");
}



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

void GangeRowsColums (int[,] inArray)
{ 
    int box;
    for(int i=0; i<inArray.GetLength(0); i++)
    {
    for(int j=0; j<i; j++)
    {
    
        box=inArray[i,j];
        inArray[i,j]=inArray[j,i];
        inArray[j,i]=box;      
    }
    
    
    }
}

    


