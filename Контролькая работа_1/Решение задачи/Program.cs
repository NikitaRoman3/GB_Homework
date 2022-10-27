void FillArray(string[] array)
{
    Console.WriteLine("Введите значение массива: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string text = Console.ReadLine() ?? "0";
        array[i] = text;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write($"{array[i]} ");
}

void ChangeArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] array = new string[size];
string[] copyarray = new string[size];
FillArray(array);
Console.WriteLine("Заданный массив:");
PrintArray(array);
Console.WriteLine("");
ChangeArray(array, copyarray);
Console.WriteLine("Новый массив с перенесенными значениями: ");
PrintArray(copyarray);