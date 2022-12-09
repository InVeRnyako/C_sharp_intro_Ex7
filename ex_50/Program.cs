// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] array = GenerateArrayWithNumbers(15, 5, 10, 20);

int row = GetIntNatFromUser("Поиск элемента по индексам [x, y]. Введите x: ");
int col = GetIntNatFromUser($"Поиск элемента по индексам [{row}, y]. Введите y: ");

PrintArray(array);
GetNumberFromArrayAtPosition(row, col, array);


void GetNumberFromArrayAtPosition(int row, int col, int[,] array)
{
    if (row > array.GetLength(0) - 1 || col > array.GetLength(1) - 1)
        Console.WriteLine("Массив не содержит чисел по заданным индексам.");
    else
        Console.WriteLine($"[{row} , {col}] -> {array[row, col]}");
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

int[,] GenerateArrayWithNumbers(int arrayRows, int arrayColumns, int lowLimit, int highLimitIncluded)
{
    Random rnd = new Random();
    int[,] generatedArray = new int[arrayRows, arrayColumns];

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
		generatedArray[i,j] = rnd.Next(lowLimit, highLimitIncluded + 1);
    }
    return generatedArray;
}

void PrintArray(int[,] inArray)
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