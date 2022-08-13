Console.Clear();
int Q=0;
try
{
   Console.Write("Введите номер четверти: ");
   Q = int.Parse (Console.ReadLine()??"");
}

catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных {exc.Message}");
}
switch (Q)
{
    case 1:
    Console.WriteLine ("X>0, Y>0");
    break;
    
   case 2:
    Console.WriteLine ("X<0, Y>0");
    break;

    case 3:
    Console.WriteLine ("X>0, Y<0");
    break;

    case 4:
    Console.WriteLine ("X<0, Y<0");
    break;


    default:
    Console.WriteLine ("Неверное значение");
    break;
}



