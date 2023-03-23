// Обсуждение домашнего задания к Семинару №3:

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ВАРИАНТ решения (мой)
// Console.Write("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// //Console.WriteLine("Расстояние между 3 точками:" + x1 + "," + y1 + "," + z1 + "," + x2 + "," + y2 + "," + z2 + " = " + d );

// Console.WriteLine($"Расстояние между 3 точками: {x1},{y1},{z1}, {x2},{y2},{z2} = {Math.Round(d,2)}");


// ВАРИАНТ решения преподавателя:

double GetInputNumbers(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

(double x, double y, double z) GetPointIn3DArea() // котеж (?) - позволяет объединить все переменные в одну.
{
    double x = GetInputNumbers("Введите координату x: ");
    double y = GetInputNumbers("Введите координату y: ");
    double z = GetInputNumbers("Введите координату z: ");

    return (x, y, z);
}

double GetDistanceIn3DArea((double x, double y, double z) point1, (double x, double y, double z) point2) // За счет котежа (выше строки 37) объявление переменных убирается.
{
    double distanceX = Math.Pow(point2.x - point1.x, 2);
    double distanceY = Math.Pow(point2.y - point1.y, 2);
    double distanceZ = Math.Pow(point2.z - point1.z, 2);

    return Math.Sqrt(distanceX + distanceY + distanceZ);
}

(double x, double y, double z) point1 = GetPointIn3DArea();
(double x, double y, double z) point2 = GetPointIn3DArea();
// За счет котежа (выше строки 37 и 55-56) объявление переменных ниже убирается.
// double x1 = GetInputNumbers("Введите координату x1: ");
// double y1 = GetInputNumbers("Введите координату y1: ");
// double z1 = GetInputNumbers("Введите координату z1: ");

// double x2 = GetInputNumbers("Введите координату x2: ");
// double y2 = GetInputNumbers("Введите координату x2: ");
// double z2 = GetInputNumbers("Введите координату x2: ");

Console.WriteLine("Расстояние между точками: " + Math.Round(GetDistanceIn3DArea(point1, point2)), 2);