// Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// нельзя использовать pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Задача 25");

Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести число: ");
int d = Convert.ToInt32(Console.ReadLine());

void DegreeOfNumber(int number, int degree)
{
    int result = 1;
    for(int l = 1; l <= degree; l++)
    {
        result = result * number;
    }
    Console.WriteLine($"Число {number} в степени {degree} = {result}");
}

DegreeOfNumber(N, d);