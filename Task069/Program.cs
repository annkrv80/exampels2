// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int num1 = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое число В: ", "Ошибква ввода!");
GetPow(num1,num2);

Console.WriteLine($"\t {num1} в степени {num2} равно {GetPow(num1,num2)}");



int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetPow(int n, int rank)
{
    if(rank==0) return 1;
    if(rank==1) return n;
    if(num1==0) return 0;
    
    else return n*GetPow(n,rank-1);
    
}


