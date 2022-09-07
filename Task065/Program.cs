Console.Clear();

Console.WriteLine("Введите целое число n1: ");
int n1 = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите целое число n2: ");
int n2 = int.Parse(Console.ReadLine()??"");

PrintNumbers(n1,n2);


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

