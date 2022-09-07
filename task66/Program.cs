/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите два натуральных числа: ");
Console.WriteLine("Введите меньшее число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    int auxiliaryNumber = numberM;
    numberM = numberN;
    numberN = auxiliaryNumber;
}

int SumNaturalNumbers(int lesserNumber, int greaterNumber)
{
    if (lesserNumber == greaterNumber) return greaterNumber;
    return (lesserNumber + SumNaturalNumbers(lesserNumber + 1, greaterNumber));
}

Console.WriteLine($"Сумма натуральных чисел от {numberN} до {numberM}:  {SumNaturalNumbers(numberM, numberN)}");


