// Задача 32: 
// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(leftRangeValue, rightRangeValue + 1);

    return array;
}

void PrintArrayInConsosole(int[] array)
{
    Console.Write("[{0}] -> ", string.Join(", ", array));
}

void mumultiplicationArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int size = 12;
int[] array = CreateAndFillArray(size, -9, 9);
PrintArrayInConsosole(array);
mumultiplicationArray(array);
PrintArrayInConsosole(array);