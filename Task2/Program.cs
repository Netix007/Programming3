// Задать номер четверти, показать диапазоны для возможных координат

int InputNumber ()
{
    int n = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write("Введите номер четверти для отображения возможных координат: ");
        string text = Console.ReadLine();
        if (Int32.TryParse(text, out n) && 0<n && n<5)
        {
            isError = false;
        }
    }
    return n;
}

int n = InputNumber();
if (n == 1)
{
    Console.WriteLine("Диапазон возможных координат: x > 0, y > 0");
}
else if (n == 2)
{
    Console.WriteLine("Диапазон возможных координат: x < 0, y > 0");
}
else if (n == 3)
{
    Console.WriteLine("Диапазон возможных координат: x < 0, y < 0");
}
else if (n == 4)
{
    Console.WriteLine("Диапазон возможных координат: x > 0, y < 0");
}