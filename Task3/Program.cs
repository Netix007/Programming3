// Задача 22: Найти расстояние между точками в пространстве 2D/3D

int[] InputCoordinates(string dotNumber) // ввод координат точки
{
    int[] dot = new int[3];
    Console.WriteLine($"Введите координаты {dotNumber} точки");
    
    dot[0] = CheckError("x");
    dot[1] = CheckError("y");
    dot[2] = CheckError("z");
    return dot;
}

int CheckError(string x) // проверка введенных данных
{
    int result = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write($"{x} = ");
        string text = Console.ReadLine();
        if (Int32.TryParse(text, out result))
        {
            isError = false;
        }
    }
    return result;
}

double DistanceCalculation (int[] dot1, int[] dot2) // Рассет расстояния между двумя точками
{
    double distance = 0;
    for (int i = 0; i < 3; i++)
    {
        distance = distance + (dot1[i]-dot2[i])*(dot1[i]-dot2[i]);
    }
    distance = Math.Sqrt(distance);
    return distance;
}

int[] dot1 = InputCoordinates("первой");
int[] dot2 = InputCoordinates("второй");
double distance = DistanceCalculation(dot1, dot2);
Console.Write("Расстояние между точками с координатами ");
Console.Write($"({dot1[0]}, {dot1[1]}, {dot1[2]}) и ");
Console.WriteLine($"({dot2[0]}, {dot2[1]}, {dot2[2]}) равно: {distance}");