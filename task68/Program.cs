/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.WriteLine("Введите два натуральных числа: ");
Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine($"Функция Аккермана({numberM},{numberN})   равна: {AckermanFunction(numberM, numberN)}");

