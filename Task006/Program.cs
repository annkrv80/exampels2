Console.Clear();

int num1 = new Random().Next(10, 100);
int num2 = new Random().Next(10, 100);
int balance = num1 % num2;

if (balance == 0)
{
    Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    Console.WriteLine($"{num1} не кратно {num2} остаток {balance}");
}
