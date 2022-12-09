// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] array = GenerateArrayWithNumbers(5, 5, 10, 20);
PrintDDArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintDArray(GetAverageOfArrayColumns(array));

double[] GetAverageOfArrayColumns (int [,] inputArray)
{
    int sum;
    double [] sumsArray = new double[inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            sum += inputArray[j,i];
            
        }
        sumsArray[i] = (double)sum / inputArray.GetLength(1);
    }
    return sumsArray;
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

void PrintDDArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i, j]} ");
        }
         Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        Console.Write($"{inArray[i]} ");
    Console.WriteLine();
}