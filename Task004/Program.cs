void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
        }
    }
int [] array = new int [10]; // в массиве 10 элементов

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если искомого числа нет в массиве
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //если необходимо остновить программу после первого найденого значения
        }
        index++;
    }
    return position;

}
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 8);
Console.WriteLine(pos);
