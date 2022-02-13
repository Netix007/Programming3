// Задача 24: Найти кубы чисел от 1 до N

int InputNumber()
{
    int n = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write("Введите число N = ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out n) && n > 0)
            {
                isError = false;
            }
    }
    return n;
}

int n = InputNumber();
Console.WriteLine($"Кубы чисел от 1 до {n}");
int result = 0;
for (int i = 1; i <= n; i++)
{
    result = i*i*i;
    Console.WriteLine($"{i}^3 = {result};");
}