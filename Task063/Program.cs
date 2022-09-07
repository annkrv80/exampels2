// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Введите целое число n1: ");
int n = int.Parse(Console.ReadLine()??"");
//Console.WriteLine("Введите целое число n2: ");
//int n2 = int.Parse(Console.ReadLine()??"");

PrintNumbers(1,n);


void PrintNumbers(int start, int end)
{

    if (start == end +1) return;
    if (start == end)
    {
        Console.Write(start + ". ");
    }
    else
    {
        Console.Write(start + ", ");
    }
    PrintNumbers(start + 1,  end);

}



