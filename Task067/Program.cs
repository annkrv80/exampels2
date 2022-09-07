Console.Clear();

int num = GetNumberFromUser("Введите целое число:", "Ошибка вводаI");
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
FindDigits(num);

int FindDigits(int number)
{
    if(number/ 10 ==0) return number%10;
    
    else return FindDigits(number % 10)+ FindDigits(number/10);
}

Console.WriteLine($"сумма цифр число {num} равна {FindDigits(num)}");
