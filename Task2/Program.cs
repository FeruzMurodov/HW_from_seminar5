/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(size);
Console.WriteLine($"[{string.Join("; ", Array)}]");
int sum = 0;
for (int i = 0; i < size; i++)
{
    sum += i % 2 == 0 ? 0 : Array[i];
}
Console.WriteLine($"Сумма элементов стоящих на нечётних индексах = {sum}");

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}