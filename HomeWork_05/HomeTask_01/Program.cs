// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(leftRangeValue, rightRangeValue);

    return array;
}

void PrintArrayInConsole(int[] array)
{
    Console.Write("[{0}] -> ", string.Join(", ", array));
}

(int evenNumb, int oddNumb) ShowTotalNumberOfEvenNumbers(int[] array)
{
    (int evenNumb, int oddNumb) evenNumbers = (0, 0);

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumbers.evenNumb += 1;
        }
        // else
        // {
        //     evenNumbers.oddNumb += 0;
        // }
    }
    return evenNumbers;
}

int size = 4;
int[] array = CreateAndFillArray(size, 100, 1000);
PrintArrayInConsole(array);
(int evenNumb, int oddNumb) evenNumbers = ShowTotalNumberOfEvenNumbers(array);
System.Console.Write($"{evenNumbers.evenNumb}");