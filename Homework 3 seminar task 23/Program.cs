// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

static int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Console.Clear();
int answer = Prompt("Input number");

for (int i = 1; i <= answer; i++)
{
    Console.WriteLine($"{i*i*i}\t");
}
Console.ReadLine();