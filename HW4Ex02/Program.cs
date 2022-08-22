// Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Задча 27.");

Console.WriteLine("Введите число: ");
string? value = Console.ReadLine();

void Summ(string N)
{
    int result = 0;

    for(int i = 0; i < N.Length; i++)
    {
        result = result + N[i];
        Console.WriteLine($"{result} ");
    }
}

Summ(value);