/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(size);
Console.WriteLine($"[{string.Join("; ", Array)}]");
int countEvenNum = 0;
foreach(int el in Array)
{
    countEvenNum += el % 2 == 0 ? 1:0;
}
Console.WriteLine($"Количество чётных чисел = {countEvenNum}");

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}