/* Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62** */

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(size);
Console.WriteLine($"[{string.Join("; ", Array)}]");
int maxNumber = Array[0];
int minNumber = Array[0];
foreach (int el in Array)
{
    maxNumber = el > maxNumber ? el:maxNumber;
    minNumber = el < minNumber ? el:minNumber;
}
int result = maxNumber - minNumber;
Console.WriteLine($"Максимальное число = {maxNumber}");
Console.WriteLine($"Минимальное число = {minNumber}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result}");

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}
