// Обсуждение домашнего задания к Семинару №3:

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// ВАРИАНТ решения (мой):

// Console.Write("Введите число N: ");
// int finish = Convert.ToInt32(Console.ReadLine()); 
// int start = 1; 

// while (start <= finish)
// {
//     Console.Write(Math.Pow(start,3) + " ");
//     start++; 
// }

// ВАРИАНТ решения преподавателя:
int GetInputNumbers(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string GetTableCube(int N)
{
    string tableCube = ("Результат = ");
    for (int i = 1; i <= N; i++)
    {
        int numberCube = (int) Math.Pow(i, 3);
        if (i != N)
            tableCube += (numberCube + ", ");
        else
            tableCube += (numberCube);

    }
    return tableCube;
}

int N = GetInputNumbers("Введите число N: ");

System.Console.WriteLine((GetTableCube(N)));