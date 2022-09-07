//Задача 19 HARD - необязательная
//Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.

bool Palindrom(int x)
{
    int i = 0;
    int j = x;
    while (j != 0) 
    {
        i = (i * 10) + (j % 10);
        j = j / 10;
    }
    return (i == x);
}

void PrintResult(string [] args)
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (Palindrom(x) == true) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
    
}
PrintResult(args);
