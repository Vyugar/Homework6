/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] GetUserArray(int length, int start, int end)
{
    Console.Write("Введите число от 1 до 5, которое определит размер массива: ");

    length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите любое число массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;

}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int NumberGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] newArray = GetUserArray(5, -100, 999);
Console.WriteLine();
PrintArray(newArray);
int countNumberMoreZero = NumberGreaterZero(newArray);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0, введенных пользователем = {countNumberMoreZero}");
Console.WriteLine();