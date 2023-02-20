// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
char[] arr = num.ToString().ToCharArray();
ReadArray(arr);
//Console.WriteLine(arr[2]);
FindNumber(arr);

void ReadArray(char[]array)
{
    for (int i=0 ; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FindNumber(char[]array)
{
    for (int i=0 ; i<array.Length; i++)
    if (array[i] >= 2)
    Console.WriteLine(array[2]);
    else 
    Console.WriteLine("There is no third number");
}
