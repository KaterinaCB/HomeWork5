//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int [] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    return array;
}
int [] mas = FillArray(10);

int Elements(int [] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
} 
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива равно -> {Elements(mas)}");