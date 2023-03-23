// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


//ВАРИАНТ решения без методов (функций):

// int size = 12;
// int[] array = new int[size]; // New - операторы выделения памяти, память выделяется под значение
// // указанное в []. 

// Random rnd = new Random(); // Переменная для создания случайных чисел в цикле ниже.
// for (int i = 0; i < array.Length; i++) // Цикл по заполнению массива случайными числами.
// {
//     array[i] = rnd.Next(-9, 10); // Конечное значение диапазона указывается на единицу больше,
//     // чем в условиях, т.к. указанное крайнее число не входит в диапазон.
// }

// System.Console.WriteLine(string.Join(", ", array)); // Способ вывода массива вместо цикла,
// // указанного ниже.

// // for (int i = 0; i < array.Length; i++) // Цикл по выводу чисел, созданных в цикле выше.
// // {
// //     System.Console.WriteLine(array[i]);
// // }

// (int moreThanZero, int lessThanZero) ammounts = (0, 0);

// for (int i = 0; i < array.Length; i++) // Цикл для прохода по массиву.
// {
//     if (array[i] > 0)
//         ammounts.moreThanZero += array[i];
//     else
//         ammounts.lessThanZero += array[i];
// }

// System.Console.Write($"Больше 0 = {ammounts.moreThanZero}; Меньше 0 = {ammounts.lessThanZero}");

//ВАРИАНТ решения с методами (функциями0:

int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
// Метод (функция) по наполнению массива и возврату, заполненного массива.
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(leftRangeValue, rightRangeValue);
    }
    return array;
}

void PrintArrayInConsole(int[] array) // Метод (функция) по выводу массива в консоль.
{
    System.Console.WriteLine(string.Join(", ", array));
}

(int moreThanZero, int lessThanZero) GetSummsNumbersLessAndMoreZero(int[] array)
{
    (int moreThanZero, int lessThanZero) ammounts = (0, 0);

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            ammounts.moreThanZero += array[i];
        else
            ammounts.lessThanZero += array[i];          
    }
    return ammounts;
}

int size = 12; // Объявление переменной с размером массива.
int[] array = CreateAndFillArray(size, -9, 10); // Заполнение массива.
PrintArrayInConsole(array); // Вывод массива в консоль.
(int moreThanZero, int lessThanZero) ammounts = GetSummsNumbersLessAndMoreZero(array); //Получение
// суммы числе больших и меньших нуля.

System.Console.Write($"Больше 0 = {ammounts.moreThanZero}; Меньше 0 = {ammounts.lessThanZero}");