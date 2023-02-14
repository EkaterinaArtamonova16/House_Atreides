// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

void ReadArray(char[]array)
{
    for (int i=0 ; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


char[] arr = num.ToString().ToCharArray();
ReadArray(arr);
Console.WriteLine(arr[2]);
