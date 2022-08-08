int [] array = {1,44,3,4,55,64,55,8};

int n=array.Length; //количество элементов в массиве
int find =55;
int index =0;

while(index<n)
{
     if (array[index]==find)
     {
        Console.WriteLine(index);
        break;// прерви после выполнения условия
     }
//index=index+1;
index++;
}
