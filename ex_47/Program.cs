// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Двумерный массив [m,n], заполненный случайными вещественными числами");
int m = GetIntNatFromUser("Введите число m: ");
int n = GetIntNatFromUser("Введите число n: ");
double[,] array = GenerateArrayWithDoubles(m, n, 10.0, 20.0);

PrintDoubleArray(array);

static double[,] GenerateArrayWithDoubles(int arrayRows, int arrayColumns, double lowLimit, double highLimit)
{
    Random rnd = new Random();
    double [,] generatedArray = new double[arrayRows, arrayColumns];

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
		    generatedArray[i,j] = rnd.NextDouble() * (highLimit - lowLimit) + lowLimit;
    }
    return generatedArray;
}

int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}

void PrintDoubleArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
         Console.WriteLine();
     }
}