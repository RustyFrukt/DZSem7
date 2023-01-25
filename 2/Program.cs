/* Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли 
такое число в двумерном массиве, а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
bool num = true;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] == number)
        {
            num = false;
            Console.WriteLine("Число присутствует");
        }
    }
}
if (num) Console.WriteLine("Упс, число отсутствует");