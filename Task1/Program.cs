// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] ConvertorIB(int[] array)
{
    bool[] x = new bool[4];
    for (int i = 0; i < 4; i++)
    {
        x[i] = Convert.ToBoolean(array[i]);
    }
    return x;
}

int[] x = {0, 0, 1, 1};
int[] y = {0, 1, 0, 1};
bool isCorrect = true;
Console.WriteLine("X  |  Y  |  ¬(X ⋁ Y)   |   ¬X ⋀ ¬Y");
Console.WriteLine("-------------------------------------");
bool[] boolX = ConvertorIB(x);
bool[] boolY = ConvertorIB(y);
for (int i = 0; i < 4; i++)
{
    Console.Write($"{Convert.ToInt32(boolX[i])}  |  {Convert.ToInt32(boolY[i])}");
    Console.WriteLine($"  |      {Convert.ToInt32(!(boolX[i]||boolY[i]))}      |      {Convert.ToInt32(!boolX[i]&&!boolY[i])}");
    Console.WriteLine("-------------------------------------");
    if (!(boolX[i]||boolY[i]) != !boolX[i]&&!boolY[i])
    {
        isCorrect = false;
        break;
    }
}
if (isCorrect)
{
    Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно");
}
