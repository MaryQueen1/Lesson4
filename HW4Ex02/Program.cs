// Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Задча 27.");

int[] CreateMassiv()
{
    Console.WriteLine("Введите число: ");
    string? value = Console.ReadLine();
    string[] V = value.Split("");
    int[] Value = new int[V.Length];
    for(int i = 0; i < V.Length; i++)
    {
        Value[i] = Convert.ToInt32(V[i]);
    }
    return Value;
}

int[] Number = CreateMassiv();

void Summ(int[] N)
{
    for(int i = 0; i < N.Length; i++)
    {
        int result = 0;
        result = result + N[i];
        Console.WriteLine($"сумма {Number} = {N[i]}");
    }
}

Summ(Number);