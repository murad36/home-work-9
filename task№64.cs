// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

string NumbersRec1(int a, int b)
{
if (a < b + 1) return $"{a} " + NumbersRec1(a + 1, b);
else return String.Empty;
}
System.Console.WriteLine(NumbersRec1(1, 8));
