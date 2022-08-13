Console.Clear();
int x1 = 0;
int y1 = 0;
int x2 = 0;
int y2 = 0;
double R = 0;

try
{
    Console.Write("Введите координату x1 ");
    x1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите координату y1 ");
    y1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите координату x2 ");
    x2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите координату y2");
    y2 = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.Write($"Ошибка!{exc.Message}");
    return;
}
R = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

Console.WriteLine(R - R % 0.01);