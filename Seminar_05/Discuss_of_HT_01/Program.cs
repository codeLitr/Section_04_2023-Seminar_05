// Обсуждение домашнего задания к Семинару №3:

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// ВАРИАНТ решения (мой):

// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int temp = Prompt("Введите пятизначное число: ");
// if (temp < 10000 || temp > 99999)
// {
//     Console.WriteLine("Вы ввели некорректное число");
// }
// else
// {
//     string str = temp.ToString();
//     int[] palindrom = new int[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         palindrom[i] = int.Parse(str[i].ToString());
//     }
//     if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// ВАРИАНТ решения преподавателя:

int GetInputNumbers(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsPolindrom(int a)
{
    return (a / 10000 == a % 10 && (a / 1000) % 10 == (a / 10) % 10);
}

int a = GetInputNumbers("Введите пятизначное число: ");

if (a < 9999 || a > 99999)
{
    System.Console.WriteLine("Введено не пятизначное число");
    return;
}

if (IsPolindrom(a))
    System.Console.WriteLine("Число является палиндромом");
else
    System.Console.WriteLine("Число является не палиндромом");
    