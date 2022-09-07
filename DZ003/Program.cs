//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double [] FillArray()
{
    double [] array = new double [10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
        if (i != array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    return array;
}
double [] mas = FillArray();

double MaxMinDifElements(double [] array)
{
    double max = array[0];
    double min = array[0];
    double dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        dif = max - min;
    }
    return dif;
}
Console.WriteLine($"Разница максимального и минимального элемента равна -> {MaxMinDifElements(mas)}");