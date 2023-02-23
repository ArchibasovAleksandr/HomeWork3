// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void CubeLine(int num)
// {
//     int counter = 1;

//     while (counter <= num)
//     {
//         Console.WriteLine($"{counter} -> {Math.Pow(counter, 3)}");
//         counter++;
//     }
// }

// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// CubeLine(n);




// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrome(int num)
// {
//     int first = num / 10000;
//     int fifth = num % 10;
//     if (first == fifth)
//     {
//         int second = (num / 1000) % 10;
//         int fourth = num % 100 /10;
//         if (second == fourth)
//         {
//             Console.WriteLine($"{num} -> Да");
//         }
//         else
//         {
//             Console.WriteLine($"{num} -> Нет");
//         }
//     }
//     else
//         {
//             Console.WriteLine($"{num} -> Нет");
//         }
// }

// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Palindrome(n);





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double xb, double yb, double za, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2)),2);
// }

// Console.WriteLine("Input coordinate x for first point:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y for first point:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate z for first point:");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate x for second point:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y for second point:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate z for second point:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,za,xb,yb,zb)}");
