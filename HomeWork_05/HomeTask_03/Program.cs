// Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
{
    double[] array = new double[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.Next(leftRangeValue, rightRangeValue) + rnd.NextDouble(), 2);

    return array;
}

void PrintArrayInConsole(double[] array)
{
    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    System.Console.WriteLine();
    Console.WriteLine("[{0}]", string.Join(", ", array));
    System.Console.WriteLine();
}

(double maxNumb, double minNumb, double subtraction) CalculateSubtractionMinMaxNumbers(double[] array)
{
    (double maxNumb, double minNumb, double subtraction) subtractionEquals = (0, 0, 0);

    for (int i = 0; i < array.Length; i++)
    {
        if (subtractionEquals.maxNumb < array[i])
        {
            subtractionEquals.maxNumb = array[i];
        }
        else
        {
            subtractionEquals.minNumb = array[i];
            subtractionEquals.subtraction = Math.Round((subtractionEquals.maxNumb - subtractionEquals.minNumb), 2);
        }
    }
    return subtractionEquals;
}

int size = 5;
double[] array = CreateAndFillArray(size, 0, 100);
PrintArrayInConsole(array);
(double maxNumb, double minNumb, double subtraction) subtractionEquals = CalculateSubtractionMinMaxNumbers(array);
System.Console.WriteLine($"Минимальный элемент массива = {subtractionEquals.minNumb}");
System.Console.WriteLine($"Максимальный элемент массива = {subtractionEquals.maxNumb}");
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным элементами массива:");
System.Console.WriteLine($"{subtractionEquals.maxNumb} - {subtractionEquals.minNumb} = {subtractionEquals.subtraction}");