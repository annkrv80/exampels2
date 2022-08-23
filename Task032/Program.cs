// Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
Console.Clear();
int [] array=GetArray(5,-4,4);
int[]GetArray(int size,int minValue, int maxValue)
{
    int [] arr= new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i]=new Random(). Next(minValue,maxValue+1);
    }
    return arr;
}

PrintArray(array);


for(int i =0;i<array.Length; i++)
{
    array[i]=array[i]*(-1);
}



void PrintArray(int[] array)
{
    Console.WriteLine();
    
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write($"{array[i]} ");
    }
}
Console.WriteLine();
Console.Write("Преобразованный массив");
PrintArray(array);
