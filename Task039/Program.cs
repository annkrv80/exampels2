// Напишите программу, которая перевернёт одномерный массив 
Console.Clear();

int[] array=GetArray(10,0,20);
Console.WriteLine(String.Join(" ",array));

int[] reversArray=reversArray1(array);
Console.WriteLine(String.Join(" ",reversArray));

ReversArray2(array);
Console.WriteLine(String.Join(" ",array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for( int i=0; i<size; i++)
    {
        res[i]=new Random().Next(minValue,maxValue+1);
    }
    return res;
}


int[] reversArray1(int[] inArray)
{
    int[] result=new int[inArray.Length];
    for(int i=0; i<inArray.Length; i++)
    {
        result[i]=inArray[inArray.Length-1-i];
    }
    return result;
}

void ReversArray2(int[] inArray)
{
    for(int i=0; i<inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i]=inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i]=k;
    }
}