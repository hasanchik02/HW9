// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
PrintNumbers(number, a);


void PrintNumbers (int n, int a)
{
    if (a > n) return;
    PrintNumbers(n, a + 1);
    Console.Write(a + " ");
}
