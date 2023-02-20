// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 6:
    Console.WriteLine("Saturday");
    break;
    
    case 7:
    Console.WriteLine("Sunday");
    break;
    
    default:
    Console.WriteLine("This is not weekend");
    break;
}

