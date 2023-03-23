// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число 
// в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateAndFillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(minValue, maxValue + 1);

    return array;
}

void PrintArrayInConsosole(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

void FindTheNumber(int[] array, int interNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == interNumber)
        {
            System.Console.WriteLine("Yes");
            return;
        }
    }

    System.Console.WriteLine("No");
}

int size = 12;
int[] array = CreateAndFillArray(size, -9, 9);
PrintArrayInConsosole(array);
System.Console.WriteLine("Please enter a number: ");
int interNumber = Convert.ToInt32(Console.ReadLine());
FindTheNumber(array, interNumber);