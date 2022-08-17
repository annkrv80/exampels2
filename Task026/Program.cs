//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Clear();
 int num=GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

 int GetNumberFromUser(string message, string errorMessage)
 {
    while(true)
    {
        Console.Write(message);
        bool isCorrect=int.TryParse(Console.ReadLine(), out int userNumber);

        if(isCorrect)
        return userNumber;
        Console.WriteLine(errorMessage);
    }
 }

Console.WriteLine("Количество цифр в числе");
int cycleNumber=GetCycleNumber(num);
Console.WriteLine($"\tВ числе {num} - {cycleNumber} цифр.");

int GetCycleNumber(int number)
{
    int count=0;
    
   
    while(number>0)
    {
        number/=10;
        count++;
    }
    return count;
}
